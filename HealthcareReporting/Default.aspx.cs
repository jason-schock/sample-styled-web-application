using System;
using System.Web.Services;
using System.Web.UI;
using HealthcareReporting.Services;

namespace HealthcareReporting
{
	public partial class Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ucGrid.Employees = new EmployeeRepository().ListEmployees();
		}

		[WebMethod]
		public static void Save(string updates)
		{
			new EmployeeRepository().UpdateEmployees(updates);
		}

		protected void MapDeductionsPlans(object sender, EventArgs e)
		{
			Response.Redirect("MapDeductionsPlans.aspx");
		}
	}
}