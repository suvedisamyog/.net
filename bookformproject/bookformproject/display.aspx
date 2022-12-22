<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="display.aspx.cs" Inherits="bookformproject.display" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
     BOOK NAME:   <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label><br />
     ISBN:   <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label><br />
     WRITER:   <asp:Label ID="Label3" runat="server" Text="Label3"></asp:Label><br />
     PUBLICATION:   <asp:Label ID="Label4" runat="server" Text="Label4"></asp:Label><br />
    </div>
</asp:Content>
