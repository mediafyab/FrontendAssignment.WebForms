<%@ Page Title="Products Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FrontendAssignment._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <asp:Repeater ID="rpt" runat="server">
            <ItemTemplate>
                <tr>
                    <td>
                        <img src="<%# Eval("Image")%>" width="40" />
                    </td>
                    <td><%# Eval("Name")%></td>
                    <td><%# Eval("FromPrice")%></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
