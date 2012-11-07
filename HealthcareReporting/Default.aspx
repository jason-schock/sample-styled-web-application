<%@ Page Title="" Language="C#" MasterPageFile="~/GlobalMasterPages/globalmaster.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HealthcareReporting.Default" %>
<%@ Register TagPrefix="uc" TagName="Header" Src="~/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Grid" Src="~/Grid.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
	<title>Netchex Online</title>
	<script src="Includes/default.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
<form id="form1" runat="server">
	<uc:Header runat="server" id="ucHeader" Title="Form W-2 Reporting of Employer-Sponsored Health Coverage" SubTitle="Company: 132 - (DEMO) AA SUPPLY COMPANY!!" />
	<div class="subheader">
		<span>Employee List</span>
		<asp:Button runat="server" CssClass="right styled" ID="btnExport" Text="Export" OnClick="Export" />
		<input class="right styled" type="button" id="btnImportAdjustments" value="Import Adjustment Amounts"/>
		<input class="right styled" type="button" id="btnMapDeductionsPlans" value="Map Deductions/Plans"/>
		<asp:DropDownList runat="server" ID="ddlYear" CssClass="right" AutoPostBack="True" />
	</div>
	<uc:Grid runat="server" id="ucGrid" />
</form>
</asp:Content>
