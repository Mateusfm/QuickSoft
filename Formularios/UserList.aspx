<%@ Page Title="Users" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Formularios.UserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <section>
            <div>
                <hgroup>
                    <h2><%: Page.Title %></h2>
                </hgroup>

                <asp:ListView ID="userList" runat="server" 
                    DataKeyNames="UserID" GroupItemCount="3"
                    ItemType="Formularios.Models.User" SelectMethod="GetUsers">
                    <EmptyDataTemplate>
                        <table >
                            <tr>
                                <td>No data was returned.</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <EmptyItemTemplate>
                        <td/>
                    </EmptyItemTemplate>
                    <GroupTemplate>
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <td runat="server">
                            <table>
                                <tr>
                                    <td>
                                        <a href="UserDetails.aspx?userID=<%#:Item.UserID%>">
                                            <span>
                                                <%#:Item.UserName%>
                                            </span>
                                        </a>
                                        <br />
                                        <span>
                                            <b>E-mail: </b><%#:Item.Email%>
                                        </span>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                            </p>
                        </td>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table style="width:100%;">
                            <tbody>
                                <tr>
                                    <td>
                                        <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                            <tr id="groupPlaceholder"></tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                </tr>
                                <tr></tr>
                            </tbody>
                        </table>
                    </LayoutTemplate>
                </asp:ListView>
            </div>
        </section>
    </section>

</asp:Content>
