<%@ Page Title="" Language="C#" MasterPageFile="~/GlobalMasterPages/globalmaster.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HealthcareReporting.Default" %>
<%@ Register TagPrefix="uc" TagName="Header" Src="~/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Grid" Src="~/Grid.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
	<title>Netchex Online</title>
	<script src="Includes/default.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
	<uc:Header runat="server" id="ucHeader" Title="Form W-2 Reporting of Employer-Sponsored Health Coverage" SubTitle="Company: 132 - (DEMO) AA SUPPLY COMPANY!!" />
	<div class="subheader">
		<span>Employee List</span>
		<input class="right styled" type="button" id="btnExport" value="Export to Excel"/>
		<input class="right styled" type="button" id="btnImportAdjustments" value="Import Adjustment Amounts"/>
		<input class="right styled" type="button" id="btnMapDeductionsPlans" value="Map Deductions/Plans"/>
	</div>
	<uc:Grid runat="server" id="ucGrid" />
</asp:Content>
