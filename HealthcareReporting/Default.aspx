<%@ Page Title="" Language="C#" MasterPageFile="~/GlobalMasterPages/globalmaster.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HealthcareReporting.Default" %>
<%@ Register TagPrefix="uc" TagName="Header" Src="~/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Grid" Src="~/Grid.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
	<title>Netchex Online</title>
	<script src="Includes/grid.js" type="text/javascript"></script>
	<script type="text/javascript">
		$(document).ready(function () {
			$('#btnCancel').click(function () {
				alert("Cancelling to Calling Page...");
				window.location = "";           // <!-- window.location should return to Calling Page -->
			});
		});
	</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
	<uc:Header runat="server" id="ucHeader"
		Title="Form W-2 Reporting of Employer-Sponsored Health Coverage" 
		SubTitle="Company: 132 - (DEMO) AA SUPPLY COMPANY!!" />
	<br />
	<uc:Grid runat="server" id="ucGrid" />
	<hr />
    <table class="WhiteBoxNoPadding" style="width:100%; padding:1; border-spacing:2">
        <tr>
	        <td class="GreenHeader" style="text-align:left; width:20%; white-space:nowrap">
	            Data Item 1 Header
	        </td>
            <td class="GreenHeader" style="text-align:center; width:35%">
                Data Item 2 Header
            </td>
            <td class="GreenHeader" style="text-align:center; width:45%">
                Data Item 3 Header
            </td>
        </tr>
        <tr>
	        <td class="LightGrayBox">
	            Row 1 Data Item 1
	        </td>
            <td class="LightGrayBox" style="text-align:center">
                Row 1 Data Item 2
            </td>
            <td class="LightGrayBox" style="text-align:center">
                Row 1 Data Item 3
            </td>
        </tr>
        <tr>
	        <td class="DarkGrayBox">
	            Row 2 Data Item 1
	        </td>
            <td class="DarkGrayBox" style="text-align:center">
                Row 2 Data Item 2
            </td>
            <td class="DarkGrayBox" style="text-align:center">
                Row 2 Data Item 3
            </td>
        </tr>
        <tr>
		    <td class="BlueBox" colspan="3" style="text-align:left">
                <b>Total Footer: Count</b>
            </td>
	    </tr>
    </table>
</asp:Content>
