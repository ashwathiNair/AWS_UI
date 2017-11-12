<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AccountDetails.aspx.cs" Inherits="AWS_WebApp.Account.AccountDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Account Details for UserName:
        <asp:Label ID="LblOne" runat="server" Text="" /></h4>

     <div class="form-group">
    <asp:GridView ID="gvServiceDetails" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="InstanceType" HeaderText="Instance Type" />
            <asp:BoundField DataField="InstanceName" HeaderText="Instance Name" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:HyperLinkField DataTextField="Action" DataNavigateUrlFields="Action,InstanceId" DataNavigateUrlFormatString="~/Account/InstanceActions.aspx?Action={0}&Id={1}" HeaderText="Action" ItemStyle-Width="150" />

        </Columns>
    </asp:GridView>
         </div>

    <%--<asp:HyperLink Text="Launch Instance" runat="server" ID="lnkLaunch" NavigateUrl="~/Account/LaunchInstance.aspx"></asp:HyperLink>--%>
    <div class="form-group"/>
    <div class="form-group"/>
    <div class="form-group"/>
    <div class="form-group"/>
    <div class="form-group"/>
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button runat="server" href="~/Account/LaunchInstance.aspx"  Text="Create New Instance" CssClass="btn btn-default" OnClick="Unnamed_Click" />
        </div>
    </div>
    <div class="form-group"/>
    <div class="form-group"/>
    <div class="form-group"/>
    <div class="form-group"/>


</asp:Content>
