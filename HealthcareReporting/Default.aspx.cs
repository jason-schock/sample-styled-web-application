using System;
using System.Web.Services;
using System.Web.UI;
using HealthcareReporting.Services;
using System.Linq;

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
			var employees = updates.Split(new[] {','}).Select(CreateEmployee).Where(x => x != null);
			new EmployeeRepository().UpdateAdjustments(employees);
		}

		private static Employee CreateEmployee(string text)
		{
			var parts = text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			int year = 0;
			decimal adjustment = 0;
			var valid = parts.Length == 3 && int.TryParse(parts[1], out year) && decimal.TryParse(parts[2], out adjustment);

			return valid ? new Employee { Ssn = parts[0], DeductionSchema = new DeductionSchema {Year = year, Adjustment = adjustment} } : null;
		}
	}
}