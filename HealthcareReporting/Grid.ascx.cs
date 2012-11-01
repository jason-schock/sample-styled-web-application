using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthcareReporting.Services;

namespace HealthcareReporting
{
	public partial class Grid : UserControl
	{
		public IEnumerable<Employee> Employees { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			BindData();
		}

		protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			gvEmployees.PageIndex = e.NewPageIndex;
			BindData();
		}

		private void BindData(IEnumerable<Employee> dataSource = null)
		{
			gvEmployees.DataSource = dataSource ?? Employees;
			gvEmployees.DataBind();
		}

		protected void RowCreated(object sender, GridViewRowEventArgs e)
		{
			if (e.Row.RowType != DataControlRowType.DataRow) {
				return;
			}

			var popup = e.Row.FindControl("ucPopup") as Popup;
			if (popup != null && e.Row.DataItem is Employee) {
				popup.Deductions = ((Employee)e.Row.DataItem).Deductions;
				popup.BindData();
			}
		}

		protected void Sorting(object sender, GridViewSortEventArgs e)
		{
			if (e.SortExpression == gvEmployees.Attributes["SortExpression"]) {
				//direction is always "ascending", need to remember the last one and swap if necessary
				e.SortDirection = (e.SortDirection == SortDirection.Ascending) ? SortDirection.Descending : SortDirection.Ascending;
			}
			gvEmployees.Attributes["SortDirection"] = e.SortDirection.ToString();
			gvEmployees.Attributes["SortExpression"] = e.SortExpression;
			
			var employees = new List<Employee>(Employees);
			employees.Sort(new EmployeeComparer(e.SortExpression, e.SortDirection));

			BindData(employees);
		}

		public class EmployeeComparer : IComparer<Employee>
		{
			private readonly string _field;
			private readonly SortDirection _sortDirection;

			internal EmployeeComparer(string field, SortDirection sortDirection)
			{
				_field = field;
				_sortDirection = sortDirection;
			}

			public int Compare(Employee x, Employee y)
			{
				var result = 0;
				switch (_field) {
					case "Name":
						result = x.Name.CompareTo(y.Name);
						break;
					case "Department":
						result = x.Department.CompareTo(y.Department);
						break;
					case "Deduction":
						result = x.Deduction.CompareTo(y.Deduction);
						break;
					case "Adjustment":
						result = x.Adjustment.CompareTo(y.Adjustment);
						break;
					case "Total":
						result = x.Total.CompareTo(y.Total);
						break;
					default:
						result = 0;
						break;
				}
				return result*(_sortDirection == SortDirection.Ascending ? -1 : 1);
			}
		}
	}
}