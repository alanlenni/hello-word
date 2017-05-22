<%@ Page Title="Home page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.XtraReports.v14.2.Web, Version=14.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        ASP.NET
    </h2>
    <p align="center">
        <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" 
            ReportTypeName="XtraReport1" Theme="Aqua">
        </dx:ASPxDocumentViewer>
        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton">
        </dx:ASPxButton>
    </p>
</asp:Content>