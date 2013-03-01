<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Adminer.Dashboard" %>
<%@ Register Assembly="Twitter.Web.Controls" Namespace="Twitter.Web.Controls" TagPrefix="twc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <twc:TabControl ID="TabControl1" runat="server">
        <TabPages>
            <twc:TabPage ID="TabPage1" runat="server" Title="TabPage1">
            </twc:TabPage>
            <twc:TabPage ID="TabPage2" runat="server" Title="TabPage1">
            </twc:TabPage>
            <twc:TabPage ID="TabPage3" runat="server" Title="TabPage3">
            </twc:TabPage>
        </TabPages>
    </twc:TabControl>
    <br />
    <twc:Breadcrumbs ID="Breadcrumbs1" runat="server">
        <Items>
            <twc:ListItem ID="ListItem1" runat="server" Text="OS">
            </twc:ListItem>
            <twc:ListItem ID="ListItem2" runat="server" Text="Windows">
            </twc:ListItem>
            <twc:ListItem ID="ListItem3" runat="server" Text="Linux">
            </twc:ListItem>
            <twc:ListItem ID="ListItem4" runat="server" Text="MacOS">
            </twc:ListItem>
        </Items>
    </twc:Breadcrumbs>
    <br />
</asp:Content>
