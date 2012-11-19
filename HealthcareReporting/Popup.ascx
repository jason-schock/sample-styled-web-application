<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Popup.ascx.cs" Inherits="HealthcareReporting.Popup" %>
<asp:Panel runat="server" CssClass="popup">
	<asp:GridView ID="gvPopup" runat="server" Width="100%" CssClass="WhiteBoxNoPadding" CellPadding="10" AutoGenerateColumns="false">
		<HeaderStyle Font-Bold="true" ForeColor="Black"></HeaderStyle>
		<Columns>
			<asp:BoundField HeaderText="Deduction" DataField="Name" />
			<asp:BoundField HeaderText="Employee Amount" DataField="Amount" DataFormatString="${0}" />
			<asp:BoundField HeaderText="Employer Amount" DataField="EmployerAmount" DataFormatString="${0}" />
		</Columns>
	</asp:GridView>
</asp:Panel>
