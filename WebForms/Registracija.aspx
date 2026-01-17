<%>@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija"% >
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txtUsername" runat="server" Placeholder="Username" /><br /><br />
<asp:TextBox ID="txtPassword" runat="server" Placeholder="Password" TextMode="Password" /><br /><br />
<asp:TextBox ID="txtFullName" runat="server" Placeholder="Full Name" /><br /><br />
<asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /><br /><br />
<asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
</asp:Content>
