using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using CsvHelper.Configuration;
using HealthcareReporting.Services;
using System.Linq;

namespace HealthcareReporting
{
	public partial class ImportAdjustments: Page
	{
		private static readonly string _ssnId = "32";

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Page.IsPostBack) {
				UpdateAdjustments();
				return;
			}

			ucHeader.ShowLegend = true;
			ddlEployeeIdTypes.DataSource = new EmployeeRepository().ListEmployeeIdTypes();
			ddlEployeeIdTypes.DataBind();
		}

		protected void UpdateAdjustments()
		{
			if (!uploader.HasFile || ddlEployeeIdTypes.SelectedValue != _ssnId) {
				lblInfo.CssClass = "required";
				lblInfo.Text = "Please use 'SSN' as employee ID type, and specify a file.";
				return;
			}
			
			try {
				var employees = GetEmployeeAdjustments(uploader.PostedFile.InputStream);
				new EmployeeRepository().UpdateAdjustments(employees);
			}
			catch (Exception ex) {
				lblInfo.CssClass = "required";
				lblInfo.Text = "ERROR: " + ex.Message;
			}
		}

		private IEnumerable<Employee> GetEmployeeAdjustments(Stream content)
		{
			using (var reader = new CsvHelper.CsvReader(new StreamReader(content))) {
				return reader.GetRecords<CsvAdjustment>().Where(x => x.Year > 0)
							 .Select(x => new Employee {
									Id = 0,
									Ssn = x.Ssn,
									DeductionSchema = new DeductionSchema {
										Adjustment = x.Amount,
										Year = x.Year
									}
							  })
							 .ToList();
			}
		}

		public class CsvAdjustment
		{
			[CsvField(Index = 0, Name = "Employee ID", Default = "")]
			public string Ssn { get; set; }

			[CsvField(Index = 1, Name = "W-2 Year", Default = 0)]
			public int Year { get; set; }

			[CsvField(Index = 2, Name = "Adjustment Amount", Default = 0)]
			public decimal Amount { get; set; }
		}
	}
}