<%@ Page Title="" Language="C#" MasterPageFile="~/GlobalMasterPages/globalmaster.master" AutoEventWireup="true" CodeBehind="MapDeductionsPlans.aspx.cs" Inherits="HealthcareReporting.MapDeductionsPlans" %>
<%@ Register TagPrefix="uc" TagName="Header" Src="~/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Selector" Src="~/Selector.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
	<title>Netchex Online</title>
	<script src="Includes/mapdeductionplans.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
<form id="form1" runat="server">
	<uc:Header runat="server" id="ucHeader" Title="Map Deductions/Plans" SubTitle="Company: 132 - (DEMO) AA SUPPLY COMPANY!!" />
	<uc:Selector runat="server" ID="ucSelector" />
</form>
</asp:Content>
