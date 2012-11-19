<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Grid.ascx.cs" Inherits="HealthcareReporting.Grid" %>
<%@ Register TagPrefix="uc" TagName="GridPopup" Src="~/GridPopup.ascx" %>
<asp:GridView runat="server" 
	ID="gvEmployees" 
	Width="100%" 
	style="table-layout: fixed;"
	CssClass="WhiteBoxNoPadding highlightable" 
	AutoGenerateColumns="False" 
	AllowSorting="True" 
	CellPadding="5" 
	CellSpacing="5" 
	OnPageIndexChanging="PageIndexChanging"
	OnSorting="Sorting"
	OnRowCreated="RowCreated"
	AllowPaging="True">
	<HeaderStyle CssClass="header"></HeaderStyle>
	<RowStyle CssClass="LightGrayBox" />
	<AlternatingRowStyle CssClass="DarkGrayBox" />
	<PagerStyle CssClass="pager" ForeColor="Black" HorizontalAlign="Right"></PagerStyle>
	<FooterStyle CssClass="BlueBox"></FooterStyle>
	<Columns>
		<asp:TemplateField HeaderText="Name" SortExpression="Name">
			<ItemTemplate>
				<asp:Label runat="server" Width="100%" CssClass="name">
					<%# Eval("Name") %> (<%# Eval("MaskedSsn") %>)
				</asp:Label>
				<div class="id">
					<asp:HiddenField runat="server" Value='<%# Eval("Id") %>' />
				</div>
				<div class="year">
					<asp:HiddenField runat="server" Value='<%# Eval("DeductionSchema.Year") %>' />
				</div>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:BoundField HeaderText="Department" DataField="Department" SortExpression="Department">
		</asp:BoundField>
		<asp:TemplateField HeaderText="Deduction Plan/Amount" SortExpression="Deduction">
			<ItemTemplate>
				<asp:Label runat="server" CssClass="deduction" Width="100%">
					<%# Eval("DeductionSchema.TotalDeduction", "${0}")%>
				</asp:Label>
				<uc:GridPopup runat="server" id="ucGridPopup" Deductions='<%# Eval("DeductionSchema.Deductions") %>' ></uc:GridPopup>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Adjustment Amount" SortExpression="Adjustment">
			<ItemTemplate>
				<asp:Label runat="server">
					$
				</asp:Label>
				<asp:TextBox runat="server" CssClass="adjustment" Width="100%" Text='<%# Eval("DeductionSchema.Adjustment") %>' autocomplete="off">
				</asp:TextBox>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Total Amount" SortExpression="Total">
			<ItemTemplate>
				<asp:Label runat="server" Text='<%# "$" + Eval("DeductionSchema.Total") %>'>
				</asp:Label>
			</ItemTemplate>
		</asp:TemplateField>
	</Columns>
</asp:GridView>


