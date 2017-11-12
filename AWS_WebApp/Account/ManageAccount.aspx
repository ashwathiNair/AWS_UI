<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageAccount.aspx.cs" Inherits="AWS_WebApp.Account.ManageAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <asp:BulletedList ID="BulletedList5" runat="Server" DisplayMode="HyperLink"
                 BulletStyle="CustomImage" BulletImageUrl="~/Images/Aws.png" >
                <asp:ListItem Text="Launch new EC2 Instance" Value="LaunchInstance.aspx"  ></asp:ListItem>
                <asp:ListItem Text="Add new S3 Instance" Value="ManageAccount.aspx"></asp:ListItem>
            </asp:BulletedList>
</asp:Content>
