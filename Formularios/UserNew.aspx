<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserNew.aspx.cs" Inherits="Formularios.UserNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="col-lg-6">
  <div class="well bs-component">
    <div class="form-horizontal">
      <fieldset>
        <legend>Formulário</legend>

        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="txtName" CssClass="col-lg-2 control-label">Nome</asp:Label>
            <div class="col-lg-10">
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control" placeholder="Name" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName"
                    CssClass="text-danger" ErrorMessage="The name field is required." />
            </div>            
        </div>
        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-lg-2 control-label">Email</asp:Label>
            <div class="col-lg-10">
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" placeholder="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="txtTelefone" CssClass="col-lg-2 control-label">Telefone</asp:Label>
          <div class="col-lg-10">
            <asp:TextBox runat="server" class="form-control" ID="txtTelefone" placeholder="(99) 99999-9999" />
          </div>
        </div>
        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="txtCpf" CssClass="col-lg-2 control-label">CPF</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtCpf" CssClass="form-control" placeholder="999.999.999-99" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCpf"
                    CssClass="text-danger" ErrorMessage="The CPF field is required." />
            </div>
        </div>
        <div class="form-group">
            <label for="ddlUf" class="col-lg-2 control-label">Estado</label>
            <div class="col-lg-10">
                <asp:DropDownList ID="ddlUf" runat="server" CssClass="form-control" 
                        OnSelectedIndexChanged="ddlUf_SelectedIndexChanged" AutoPostBack="true" />
            </div>
        </div>
        <div class="form-group">
            <label for="ddlCidade" class="col-lg-2 control-label">Cidade</label>
            <div class="col-lg-10">
                <asp:DropDownList ID="ddlCidade" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="rblPossuiEmpresa" CssClass="col-lg-2 control-label">Possui Empresa</asp:Label>
          <div class="col-lg-10">
            <div class="radio">
               <asp:RadioButtonList ID="rblPossuiEmpresa" runat="server">
                    <asp:ListItem Selected="True" Value="1">Não</asp:ListItem>
                    <asp:ListItem Value="2" Text="Sim">Sim</asp:ListItem>
               </asp:RadioButtonList>
            </div>
          </div>
        </div>
        <div class="form-group">
          <asp:Label ID="lblData" AssociatedControlID="txtDate" runat="server" Text="Data de nascimento:" CssClass="col-lg-2 control-label"></asp:Label>
             <div class="col-lg-10">
                <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator CssClass="text-danger" ID="reqData" runat="server" ControlToValidate="txtDate" ErrorMessage="The Date field is required." />
             </div>
        </div>
        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="txtCnpj" CssClass="col-lg-2 control-label">CNPJ</asp:Label>
            <div class="col-lg-10">
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCnpj" placeholder="99999-9999" />
                <asp:RequiredFieldValidator CssClass="text-danger" ID="reqCnpj" runat="server" ControlToValidate="txtCnpj" ErrorMessage="The CNPJ field ir required." Enabled="False" />
            </div>
        </div>
        <div class="form-group">
          <asp:Label ID="labelTipoDeEmpresa" AssociatedControlID="ddlTipoDeEmpresa" runat="server" CssClass="col-lg-2 control-label">Tipo de Empresa</asp:Label>
            <div class="col-lg-10">
             <asp:DropDownList ID="ddlTipoDeEmpresa" CssClass="form-control" runat="server" Enabled="True">
                <asp:ListItem>Factory</asp:ListItem>
                <asp:ListItem>Fundo</asp:ListItem>
                <asp:ListItem>Securitizadora</asp:ListItem>
             </asp:DropDownList>
          </div>
        </div>
        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="txtArea" CssClass="col-lg-2 control-label">Observações</asp:Label>
          <div class="col-lg-10">
            <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" ID="txtArea"  />
            <span class="help-block"></span>
          </div>
        </div>
        <div class="form-group">
          <div class="col-lg-10 col-lg-offset-2">
            <button type="reset" class="btn btn-default">Cancel</button>
            <asp:Button ID="ButtonEnviar" OnClick="ButtonEnviar_Click" CssClass="btn btn-primary" runat="server" Text="Enviar" />
            <asp:Label ID="respostaEnvioLabel" runat="server" Text="Label" Visible="False"></asp:Label>
          </div>
        </div>
      </fieldset>
    </div>
  </div>
</div>

</asp:Content>
