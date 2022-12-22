<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="bookformproject.add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />  
    BOOK NAME <asp:TextBox runat="server" ID="name" /><br />
   ISBN      <asp:TextBox runat="server" ID="isbn" Width="171px" /><br />
   WRITER <asp:TextBox runat="server" ID="writer" Width="149px" /><br />
   PUBLICATION <asp:TextBox runat="server" ID="publication" Width="117px" /><br />
    <asp:Button runat="server" ID="Save" Text="save" OnClick="Save_Click" />

</asp:Content>
