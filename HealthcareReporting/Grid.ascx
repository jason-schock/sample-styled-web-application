<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Grid.ascx.cs" Inherits="HealthcareReporting.Grid" %>
<%@ Register TagPrefix="uc" TagName="Popup" Src="~/Popup.ascx" %>
<form id="form1" runat="server">
	<asp:HiddenField ID="IsDirty" runat="server" ClientIDMode="Static" />
	<asp:GridView runat="server" 
		ID="gvEmployees" 
		Width="100%" 
		style="table-layout: fixed;"
		CssClass="WhiteBoxNoPadding highlighted" 
		AutoGenerateColumns="False" 
		AllowSorting="True" 
		CellPadding="5" 
		CellSpacing="5" 
		OnPageIndexChanging="PageIndexChanging"
		OnSorting="Sorting"
		OnRowCreated="RowCreated"
		AllowPaging="True">
		<HeaderStyle CssClass="GreenHeader" Font-Bold="true" ForeColor="Black"></HeaderStyle>
		<RowStyle CssClass="LightGrayBox" />
		<AlternatingRowStyle CssClass="DarkGrayBox" />
		<PagerStyle CssClass="pager" ForeColor="Black" HorizontalAlign="Right"></PagerStyle>
		<FooterStyle CssClass="BlueBox"></FooterStyle>
		<Columns>
			<asp:TemplateField HeaderText="Name" SortExpression="Name">
				<ItemTemplate>
					<asp:Label runat="server" Width="100%" CssClass="name">
						<%# Eval("Name")%>
					</asp:Label>
					<asp:HiddenField runat="server" Value='<%# Eval("Id") %>' />
				</ItemTemplate>
			</asp:TemplateField>
			<asp:BoundField HeaderText="Department" DataField="Department" SortExpression="Department">
			</asp:BoundField>
			<asp:TemplateField HeaderText="Deduction Plan/Amount" SortExpression="Deduction">
				<ItemTemplate>
					<asp:Label runat="server" CssClass="deduction" Width="100%">
						<%# Eval("Deduction", "${0}")%>
					</asp:Label>
					<uc:Popup runat="server" id="ucPopup" Deductions='<%# Eval("Deductions") %>' ></uc:Popup>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Adjustment Amount" SortExpression="Adjustment">
				<ItemTemplate>
					<asp:Label runat="server" CssClass="adjustment" Width="100%">
						<%# Eval("Adjustment", "${0}")%>
					</asp:Label>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:BoundField HeaderText="Total Amount" DataField="Total" SortExpression="Total" DataFormatString="${0}">
			</asp:BoundField>
		</Columns>
	</asp:GridView>
</form>

