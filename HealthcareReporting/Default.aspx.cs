using System;
using System.IO;
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
			var employees = new EmployeeRepository().ListEmployees();
			if (!Page.IsPostBack) {
				ddlYear.DataSource = employees.Select(x => x.DeductionSchema.Year).Distinct().OrderBy(x => x);
				ddlYear.DataBind();
			}
			
			int year = int.Parse(ddlYear.SelectedValue);
			ucGrid.Employees = employees.Where(x => x.DeductionSchema.Year == year).ToList();
		}

		public void Export(object sender, EventArgs e)
		{
			var employees = ucGrid.Employees.Select(x => new {
				x.Id, 
				Name = x.FirstName + " " + x.LastName,
				x.DeductionSchema.Year,
				x.DeductionSchema.TotalDeduction,
				x.DeductionSchema.Adjustment
			});

			var stream = new MemoryStream();
			using (var writer = new CsvHelper.CsvWriter(new StreamWriter(stream))) {
				writer.WriteRecords(employees);
			}

			Response.Clear();
			Response.ContentType = "text/csv";
			Response.AppendHeader("Content-Disposition", "attachment; filename=Employees.csv");
			Response.BinaryWrite(stream.GetBuffer());
			Response.Flush();
			Response.Close();
		}

		[WebMethod]
		public static void Save(string updates)
		{
			var employees = updates.Split(new[] {','}).Select(ToEmployee).Where(x => x != null);
			new EmployeeRepository().UpdateAdjustments(employees);
		}

		private static Employee ToEmployee(string text)
		{
			var parts = text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			int id = 0;
			int year = 0;
			decimal adjustment = 0;
			var valid = parts.Length == 3 && int.TryParse(parts[0], out id) && int.TryParse(parts[1], out year) && decimal.TryParse(parts[2], out adjustment);

			return valid ? new Employee { Id = id, DeductionSchema = new DeductionSchema {Year = year, Adjustment = adjustment} } : null;
		}
	}
}