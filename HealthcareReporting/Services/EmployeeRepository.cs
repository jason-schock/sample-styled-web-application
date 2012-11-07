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

		/// <summary>
		/// Updates the adjustments for the given employees.
		/// </summary>
		/// <param name="employees">List of employees to update. Note that depending on the 
		/// method caller, each employee may have either Id (for adjustments manually entered by
		/// a user - in which case "Ssn" is null) or "Ssn" (for adjustments uploaded from a csv
		/// file - in which case Id is 0).</param>
		public void UpdateAdjustments(IEnumerable<Employee> employees)
		{
			var doc = new XDocument();
			doc.Add(new XElement("root", employees.Select(x => new XElement("item",
																new XAttribute("id", x.Id),
																new XAttribute("ssn", x.Ssn ?? ""),
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