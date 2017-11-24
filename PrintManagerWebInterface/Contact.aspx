<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PrintManagerWebInterface.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact</h3>
    <address>
        3000 Booth Falls Rd.<br />
        Vail, CO  81657<br />
        <abbr title="Phone">P:</abbr>
        970.476.3850 (x2999)
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:jcox@vms.edu">Jason Cox (jcox@vms.edu)</a><br />
        <strong>Marketing:</strong> <a href="mailto:coxj@vt.edu">Jason Cox</a>
    </address>
</asp:Content>
