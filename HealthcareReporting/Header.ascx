<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="HealthcareReporting.Header" %>
<table class="WhiteBoxNoPadding" style="width:100%">
	<tr>
		<td class="DarkGrayBox" colspan="2">
			<table style="width:100%; padding:1; border-spacing:2">
				<tr>
					<td class="TextTitle">
						<%: Title %>
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
						<%: SubTitle %>
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

