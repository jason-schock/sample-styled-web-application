using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthcareReporting.Services;
using System.Linq;

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

		protected void RowCreated(object sender, GridViewRowEventArgs e)
		{
			if (e.Row.RowType != DataControlRowType.DataRow) {
				return;
			}

			var popup = e.Row.FindControl("ucGridPopup") as GridPopup;
			if (popup != null && e.Row.DataItem is Employee) {
				popup.Deductions = ((Employee)e.Row.DataItem).DeductionSchema.Deductions;
				popup.BindData();
			}
		}

		protected void Sorting(object sender, GridViewSortEventArgs e)
		{
			if (e.SortExpression == SortExpression) {
				//direction is always "ascending", need to remember the last one and swap if necessary
				e.SortDirection = (SortDirection == SortDirection.Ascending) ? SortDirection.Descending : SortDirection.Ascending;
			}
			SortDirection = e.SortDirection;
			SortExpression = e.SortExpression;

			AddSortingSign();

			var employees = new List<Employee>(Employees);
			employees.Sort(new EmployeeComparer(e.SortExpression, e.SortDirection));

			BindData(employees);
		}

		private void BindData(IEnumerable<Employee> dataSource = null)
		{
			gvEmployees.DataSource = dataSource ?? Employees;
			gvEmployees.DataBind();
		}

		private SortDirection SortDirection
		{
			get { return (SortDirection)Enum.Parse(typeof(SortDirection), gvEmployees.Attributes["SortDirection"] ?? "Ascending"); }
			set { gvEmployees.Attributes["SortDirection"] = value.ToString(); }
		}

		private string SortExpression
		{
			get { return gvEmployees.Attributes["SortExpression"]; }
			set { gvEmployees.Attributes["SortExpression"] = value; }
		}

		private void AddSortingSign()
		{
			var ascending = " ▲";
			var descending = " ▼";
			foreach (var column in gvEmployees.Columns.Cast<DataControlField>()) {
				if (column.HeaderText.EndsWith(ascending) || column.HeaderText.EndsWith(descending)) {
					column.HeaderText = column.HeaderText.Substring(0, column.HeaderText.Length - 2);
				}
				if (column.SortExpression == SortExpression) {
					column.HeaderText += SortDirection == SortDirection.Ascending ? ascending : descending;
				}
			}
		}

		internal class EmployeeComparer : IComparer<Employee>
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
						result = x.DeductionSchema.TotalDeduction.CompareTo(y.DeductionSchema.TotalDeduction);
						break;
					case "Adjustment":
						result = x.DeductionSchema.Adjustment.CompareTo(y.DeductionSchema.Adjustment);
						break;
					case "Total":
						result = x.DeductionSchema.Total.CompareTo(y.DeductionSchema.Total);
						break;
					default:
						result = 0;
						break;
				}
				return result*(_sortDirection == SortDirection.Ascending ? 1 : -1);
			}
		}
	}
}