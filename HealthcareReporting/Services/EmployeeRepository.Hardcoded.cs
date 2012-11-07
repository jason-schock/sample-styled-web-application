using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareReporting.Services
{
	internal static class EmployeeRepositoryHardcoded
	{
		private static readonly Random _random = new Random(123);
		private static List<Employee> _employees;
		private static List<EmployeeIdType> _employeeIdTypes;

		internal static IEnumerable<Employee> Employees
		{
			get { return _employees ?? (_employees = CreateEmployees()); }
		}
		internal static IEnumerable<EmployeeIdType> EployeeIdTypes
		{
			get { return _employeeIdTypes ?? (_employeeIdTypes = CreateEmployeeIdTypes()); }
		}

		private static List<Employee> CreateEmployees()
		{
			var names = new[] {
				"Jeanie Holtzclaw", "Kelly Laffin", "Neil Gauger", "Tia Ulrey", "Nita Batterton", 
				"Hugh Caufield", "Allan Shanley", "Allyson Ogg", "Gay Finneran", "Clayton Buesing", 
				"Jessie Quisenberry", "Tania Lichty", "Lonnie Hirth", "Mathew Ridder", "Clayton Hillin", 
				"Darren Lowy", "Max Texeira", "Melisa Litt", "Sofia Ishibashi", "Annabelle Iorio",
				"Lonnie Schaff", "Nelson Sater", "Benita Arter", "Julio Fallis", "Tyrone Logiudice", 
				"Jessie Holoman", "Julianne Dahlquist", "Lakisha Rough", "Maria Raspberose", "Donald McMurphey"
			};

			return names.Select(CreateEmployee).ToList();
		}

		private static Employee CreateEmployee(string fullName, int id)
		{
			var names = fullName.Split(new []{' '});
			var guid = Guid.NewGuid().ToString("N");

			return new Employee {
				Id = id,
				Department = RandomDepartment(),
				FirstName = names[0],
				LastName = names[1],
				Ssn = string.Format("{0}-{1}-{2}", guid.Substring(0,3), guid.Substring(4,3), guid.Substring(5, 4)),
				DeductionSchema = RandomSchema()
			};
		}

		private static Department RandomDepartment()
		{
			var divisions = new[] { "000", "001", "002", "003" };
			var units = new[] { "000", "001" };
			var codes = new[] { "000", "001", "002" };
			var descriptions = new[] { "Developer Tools", "Online Services", "Business", "System" };

			return new Department {
				DivisionCode = divisions[_random.Next(0, divisions.Length)],
				BusinessUnitCode = units[_random.Next(0, units.Length)],
				DepartmentCode = codes[_random.Next(0, codes.Length)],
				Description = descriptions[_random.Next(0, descriptions.Length)]
			};
		}

		private static DeductionSchema RandomSchema()
		{
			var years = new[] {2010, 2011, 2012};
			var deductions = new DeductionPlansRepository().ListDeductions().ToList();
			var selected = _random.Next(0, deductions.Count);

			var result = new List<Deduction>();
			for (int i = 0; i < selected; i++) {
				result.Add(new Deduction {Name = deductions[_random.Next(0, deductions.Count)].Name, Amount = _random.Next(1,100), EmployerAmount = _random.Next(1,50)});
			}
			
			return new DeductionSchema {
				Adjustment = 0,
				Deductions = result,
				Year = years[_random.Next(0, years.Length)]
			};
		}

		private static List<EmployeeIdType> CreateEmployeeIdTypes()
		{
			return new List<EmployeeIdType> {
					new EmployeeIdType {Id = 12, Name = "Clock Number"},
					new EmployeeIdType {Id = 26, Name = "Former Employee ID"},
					new EmployeeIdType {Id = 32, Name = "SSN"},
					new EmployeeIdType {Id = 41, Name = "Employee Code"},
					new EmployeeIdType {Id = 58, Name = "Badge Number"},
				};
		}
	}
}