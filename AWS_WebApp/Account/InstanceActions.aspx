<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="InstanceActions.aspx.cs" Inherits="AWS_WebApp.Account.InstanceActions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Instance Operations</h2>
    <asp:Label runat="server" ID="lblSuccessMessage" Text="" Visible="false" style="padding-top: 100px"></asp:Label>
        <asp:Button runat="server" ID="btnOkay" OnClick="btnOkay_Click" Text="Go To Account Details" Visible="false"/>

    


</asp:Content>
