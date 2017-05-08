<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="Formularios.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="userDetail" runat="server" ItemType="Formularios.Models.User" SelectMethod ="GetUser" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.UserName %></h1>
            </div>
            <br />
            <table>
                <tr>  
                    <td style="vertical-align: top; text-align:left;">
                        <span><b>User Number:</b>&nbsp;<%#:Item.UserID %></span>
                        <br />
                        <b>e-mail:</b>&nbsp;<%#:Item.Email %>
                        <br />
                        <span><b>CPF:</b>&nbsp;<%#: Item.Cpf %></span>
                        <br />
                        <span><b>Telefone:</b>&nbsp;<%#: Item.Phone %></span>
                        <br />
                        <span><b>CNPJ:</b>&nbsp;<%#:Item.Cnpj %></span>
                        <br />
                        <span><b>Data:</b>&nbsp;<%#:Item.Data %></span>
                        <br />
                        <span><b>Tipo empresa:</b>&nbsp;<%#:Item.TypeCompany %></span>
                        <br />
                        <span><b>Cidade:</b>&nbsp;<%#:Item.City.CityName %></span>
                        <br />
                        <span><b>Estado:</b>&nbsp;<%#:Item.Uf.UfName %></span>
                        <br />
                        <span><b>Observação:</b>&nbsp;<%#:Item.Observacoes %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
