<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Grid.ascx.cs" Inherits="HealthcareReporting.Grid" %>
<%@ Register TagPrefix="uc" TagName="GridPopup" Src="~/GridPopup.ascx" %>
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
						<%# Eval("Name") %>
					</asp:Label>
					<asp:HiddenField runat="server" Value='<%# Eval("Ssn") %>' />
				</ItemTemplate>
			</asp:TemplateField>
			<asp:BoundField HeaderText="Department" DataField="Department" SortExpression="Department">
			</asp:BoundField>
			<asp:TemplateField HeaderText="Deduction Plan/Amount" SortExpression="Deduction">
				<ItemTemplate>
					<asp:Label runat="server" CssClass="deduction" Width="100%">
						<%# Eval("Deduction", "${0}")%>
					</asp:Label>
					<uc:GridPopup runat="server" id="ucGridPopup" Deductions='<%# Eval("Deductions") %>' ></uc:GridPopup>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Adjustment Amount" SortExpression="Adjustment">
				<ItemTemplate>
					<asp:Label runat="server">
						$
					</asp:Label>
					<asp:TextBox runat="server" CssClass="adjustment" Width="100%" Text='<%# Eval("Adjustment") %>' autocomplete="off">
					</asp:TextBox>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:BoundField HeaderText="Total Amount" DataField="Total" SortExpression="Total" DataFormatString="${0}">
			</asp:BoundField>
		</Columns>
	</asp:GridView>
</form>

