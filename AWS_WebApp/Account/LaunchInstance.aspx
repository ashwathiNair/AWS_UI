<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LaunchInstance.aspx.cs" Inherits="AWS_WebApp.Account.LaunchInstance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-horizontal">
    <h1>Launch new EC2 instance</h1>
    <div class="form-group">
        <asp:Label runat="server" Text="AMID" CssClass="col-md-2 control-label"></asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="txtAMID"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <asp:Label runat="server" Text="KeyPairName" CssClass="col-md-2 control-label"></asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="txtKeyPairName"></asp:TextBox>
        </div>
    </div>


    <div class="form-group">
        <asp:Label runat="server" Text="GroupName" CssClass="col-md-2 control-label"></asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="txtGroupName"></asp:TextBox>
        </div>
    </div>


    <div class="form-group">
        <asp:Label runat="server" Text="InstanceType" CssClass="col-md-2 control-label"></asp:Label>
        <div class="col-md-10">
            <asp:TextBox runat="server" ID="txtInstanceType"></asp:TextBox>
        </div>
    </div>

        <div class="form-group">
        <div class="col-md-10">
            <asp:Button runat="server" ID="btnLaunchInstance" Text="Launch Instance" OnClick="btnLaunch_Click"></asp:Button>
        </div>
    </div>

        <asp:Label runat="server" ID="lblFailureMessage" Text="Error occurred..Please try again!" Visible="false" style="padding-top: 100px"></asp:Label>

        </div>
</asp:Content>
