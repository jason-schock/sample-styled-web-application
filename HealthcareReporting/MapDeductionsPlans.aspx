<%@ Page Title="" Language="C#" MasterPageFile="~/GlobalMasterPages/globalmaster.master" AutoEventWireup="true" CodeBehind="MapDeductionsPlans.aspx.cs" Inherits="HealthcareReporting.MapDeductionsPlans" %>
<%@ Register TagPrefix="uc" TagName="Header" Src="~/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Selector" Src="~/Selector.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
	<title>Netchex Online</title>
	<script src="Includes/mapdeductions.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
	<uc:Header runat="server" id="ucHeader"
		Title="Map Deductions/Plans" 
		SubTitle="Company: 132 - (DEMO) AA SUPPLY COMPANY!!" />
	<br />
	<uc:Selector runat="server" ID="ucSelector" />
</asp:Content>
