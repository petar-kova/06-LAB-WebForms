<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shop</h2>
<asp:TextBox ID="txtName" runat="server" Placeholder="Naziv proizvoda" /><br /><br />
<asp:TextBox ID="txtDesc" runat="server" Placeholder="Opis proizvoda" /><br /><br />
<asp:Button ID="btnSave" runat="server" Text="Spremi" OnClick="btnSave_Click" /><br /><br />

<asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="true" />
</asp:Content>
