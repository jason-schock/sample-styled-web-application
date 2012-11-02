<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Selector.ascx.cs" Inherits="HealthcareReporting.Selector" %>
<form id="form1" runat="server">
	<div>
		<table>
			<tr>
				<td>
					<asp:ListBox ID="lstAvailable" runat="server" SelectionMode="Multiple" CssClass="listView" ClientIDMode="Static"></asp:ListBox>
				</td>
				<td valign="middle" align="center" style="width:100px">
					<asp:Button ID="ButtonAdd" runat="server" Text=" > " OnClick="ButtonAdd_Click" Width="50px"/>
					<br />
 					<asp:Button ID="ButtonRemove" runat="server" Text=" < " OnClick="ButtonRemove_Click" Width="50px"/>
					<br />
					<asp:Button ID="ButtonAddAll" runat="server" Text =" >> " OnClick="ButtonAddAll_Click"  Width="50px"/> 
					<br />
					<asp:Button ID="ButtonRemoveAll" runat="server" Text =" << " OnClick="ButtonRemoveAll_Click" Width="50px"/>
				</td>
				<td>
					<asp:ListBox ID="lstSelected" runat="server" SelectionMode="Multiple" CssClass="listView" ClientIDMode="Static"></asp:ListBox>
				</td>
			</tr>
		</table>
	</div>
</form>
