<%@ Page Title="" Language="C#" MasterPageFile="~/GlobalMasterPages/globalmaster.master" AutoEventWireup="true" CodeBehind="ImportAdjustments.aspx.cs" Inherits="HealthcareReporting.ImportAdjustments" %>
<%@ Register TagPrefix="uc" TagName="Header" Src="~/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Grid" Src="~/Grid.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
	<title>Netchex Online</title>
	<script src="Includes/importadjustments.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
	<uc:Header runat="server" id="ucHeader" Title="Form W-2 Reporting of Employer-Sponsored Health Coverage" SubTitle="Company: 132 - (DEMO) AA SUPPLY COMPANY!!" />
	<div class="subheader">
		<span>Import Settings</span>
	</div>
	<form id="form1" runat="server" clientidmode="Static">
		<div>
			<asp:Label runat="server" CssClass="required" Text="Employee ID Type:" />
			<asp:DropDownList runat="server" ID="ddlEployeeIdTypes" DataTextField="Name" DataValueField="Id" />
		</div>
		<div>
			<asp:FileUpload ID="uploader" runat="server" />
			<asp:Label ID="lblInfo" runat="server" />
		</div>
	</form>
</asp:Content>
