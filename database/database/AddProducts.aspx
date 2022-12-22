<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="database.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">    
    PRODUCT ID<br />  <asp:TextBox runat="server" ID="PID" /><br />
   PRODUCT NAME <br /><asp:TextBox runat="server" ID="PName" /><br />
   PRODUCT PRICE<br/> <asp:TextBox runat="server" ID="PPrice" /><br />
    <asp:Button runat="server" ID="submit" Text="SUBMIT" OnClick="submit_Click" />
</asp:Content>
