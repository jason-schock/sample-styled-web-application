using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace HealthcareReporting.Services
{
	public class EmployeeRepository
	{
		public IEnumerable<Employee> ListEmployees()
		{
			return EmployeeRepositoryHardcoded.Employees;
		}

		public IEnumerable<EmployeeIdType> ListEmployeeIdTypes()
		{
			return EmployeeRepositoryHardcoded.EployeeIdTypes;
		}

		public void UpdateAdjustments(IEnumerable<Employee> employees)
		{
			var doc = new XDocument();
			doc.Add(new XElement("root", employees.Select(x => new XElement("item",
																new XAttribute("ssn", x.Ssn),
																new XAttribute("year", x.DeductionSchema.Year),
																new XAttribute("adjustment", x.DeductionSchema.Adjustment))
															)
								)
			);
			var xml = doc.ToString(SaveOptions.DisableFormatting);
			//send xml to the database
		}
	}
}