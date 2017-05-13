using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Formularios.Models;
using System.Net.Mail;
using System.Net.Configuration;

namespace Formularios
{
    public partial class UserNew : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            IniciarDropDownEstadoCidade();
        }

        #region SelectedIndexChanged Estados e cidade

        private void IniciarDropDownEstadoCidade()
        {
            // Carregar DropDownList de estado atravéz do banco de dados
            if (!Page.IsPostBack)
            {
                UserContext bd = new UserContext();

                ddlUf.DataSource = (from c in bd.Ufs orderby c.UfName select c).ToList();

                ddlUf.DataValueField = "UfID";
                ddlUf.DataTextField = "UfName";

                ddlUf.DataBind();

                // Carrega DropDownList cidade de acordo com o estado
                CarregarDropDownListCidade(int.Parse(ddlUf.SelectedValue));
            }
        }

        protected void ddlUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ddlUf.SelectedValue))
            {
                CarregarDropDownListCidade(int.Parse(ddlUf.SelectedValue));
            }
        }

        protected void CarregarDropDownListCidade(int p)
        {
            UserContext bd = new UserContext();
            ddlCidade.DataSource = (from cidade in bd.Cities orderby cidade.CityName 
                                    where cidade.UfID == p select cidade).ToList();

            ddlCidade.DataValueField = "CityID";
            ddlCidade.DataTextField = "CityName";

            ddlCidade.DataBind();
        }
        #endregion

        #region Evento OnClick

        protected void ButtonEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
            SalvarRedirecionarUsuario();
  
        }

        private void SalvarRedirecionarUsuario()
        {
            var userContext = new UserContext();

            userContext.Database.CreateIfNotExists();

            var usuario = new User
            {
                UserName = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtTelefone.Text,            
                Cpf = txtCpf.Text,
                UfID = int.Parse(ddlUf.SelectedValue),
                CityID = int.Parse(ddlCidade.SelectedValue),
                Data = Convert.ToDateTime(txtDate.Text),
                Cnpj = txtCnpj.Text,
                TypeCompany = ddlTipoDeEmpresa.SelectedItem.Text,
                Observacoes = txtArea.Text,
            };

            userContext.Users.Add(usuario);
            userContext.SaveChanges();

            Response.Redirect("UserDetails.aspx?userID=" + usuario.UserID);
        }

        protected void EnviarEmail()
        {
            string remetenteEmail = "exemplo95@gmail.com";
            MailMessage mail = new MailMessage();
            mail.To.Add(txtEmail.Text);
            mail.From = new MailAddress(remetenteEmail, "Mateus", System.Text.Encoding.UTF8);
            mail.Subject = "Dados de Cadastro";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = RetornaHtmlDadosFormulário();
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(remetenteEmail, "password");

            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
                respostaEnvioLabel.Text = "Envio do E-mail com sucesso";
                respostaEnvioLabel.Visible = true;
            }
            catch (Exception ex)
            {
                respostaEnvioLabel.Text = "Ocorreu um erro ao enviar:" + ex.Message;
                respostaEnvioLabel.Visible = true;
            }
        }

        protected String RetornaHtmlDadosFormulário()
        {
            String str = " ";

            str = "<strong>Nome: </strong>" + txtName.Text +
                  "<br><strong>Email: </strong>" + txtEmail.Text +
                  "<br><strong>Telefone: </strong>" + txtTelefone.Text +
                  "<br><strong>Data: </strong>" + txtDate.Text +
                  "<br><strong>CPF: </strong>" + txtCpf.Text;

            if (txtCnpj.Text != "")
            {
                str += "<br><strong>CNPJ: </strong>" + txtCnpj.Text +
                    "<br><strong>Tipo: </strong>" + ddlTipoDeEmpresa.SelectedItem.Text;
            }


            str += "<br><strong>Cidade: </strong>" + ddlCidade.SelectedItem.Text +
                  "<br><strong>UF: </strong>" + ddlUf.SelectedItem.Text +
                  "<br><strong>Observações: </strong>" + txtArea.Text;

            return str;
        }
        #endregion

        protected void HabilitarCnpj(Object sender, EventArgs e)
        {
            if (rblPossuiEmpresa.SelectedItem.Text == "Sim")
            {
                txtCnpj.Enabled = true;
                ddlTipoDeEmpresa.Enabled = true;
                reqCnpj.Enabled = true;
                lblData.Text = "Data de criação da empresa ";

            }
            else
            {
                txtCnpj.Enabled = false;
                ddlTipoDeEmpresa.Enabled = false;
                reqCnpj.Enabled = false;
                lblData.Text = "Data de nascimento ";
            }

        }
    }
}
