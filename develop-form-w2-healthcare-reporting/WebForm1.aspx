<%@ Page Title="" Language="C#" MasterPageFile="~/GlobalMasterPages/globalmaster.master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="develop_form_w2_healthcare_reporting.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <title>Netchex Online</title>

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
    <table class="WhiteBoxNoPadding" style="width:100%">
        <tr>
		    <td class="DarkGrayBox" colspan="2">
			    <table style="width:100%; padding:1; border-spacing:2">
				    <tr>
					    <td class="TextTitle">
						    Page Title
				        </td>
                        <td style="text-align:right">
						    <a href=""> <!-- href should link to /login/frmLogout.asp -->
						    <img src="/images/slices/icon_logout.jpg" alt="logout" style="vertical-align:middle" class="Icon" />Logout</a>
					    </td>
				    </tr>
			    </table>
		    </td>
	    </tr>
    </table>
    <table class="WhiteBoxNoPadding" style="width:100%">
	    <tr>
		    <td class="LightGrayBox" style="width:100%">
			    <table style="width:100%; padding:0; border-spacing:0">
				    <tr>
					    <td style="width:30%;white-space:nowrap;text-align:left">
                            Page Sub-Title
					    </td>
					    <td style="width:40%;white-space:nowrap;text-align:center">
                            LEGEND: <span class="RequiredFields">Required</span>, Optional
					    </td>
					    <td style="width:30%;white-space:nowrap;text-align:right">
                            <input class="Pointer" type="button" id="btnUpdate" value="Update"/>
                            <input class="Pointer" type="button" id="btnCancel" value="Calling Page"/>
					    </td>
				    </tr>
			    </table>
		    </td>
	    </tr>
    </table>
    <br />
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
