using System;
using System.Collections.Generic;

namespace HealthcareReporting.Services
{
	public class EmployeeRepository
	{
		/// <summary>
		/// Hardcoded one - in the real app will return all employees.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Employee> ListEmployees()
		{
			return new List<Employee> {
				new Employee { Id=1, Name = "Jeanie Holtzclaw", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=2, Name = "Eve Pickrell", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=3, Name = "Kelly Laffin", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Id=4, Name = "Neil Gauger", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=5, Name = "Tia Ulrey", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=6, Name = "Nita Batterton", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Id=7, Name = "Hugh Caufield", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=8, Name = "Allan Shanley", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=9, Name = "Allyson Ogg", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=10, Name = "Gay Finneran", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Id=11, Name = "Clayton Buesing", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=12, Name = "Jessie Quisenberry", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Id=13, Name = "Tania Lichty", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=14, Name = "Lonnie Hirth", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=15, Name = "Mathew Ridder", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Id=16, Name = "Clayton Hillin", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Id=17, Name = "Darren Lowy", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=18, Name = "Max Texeira", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=19, Name = "Melisa Litt", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Id=20, Name = "Sofia Ishibashi", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=21, Name = "Annabelle Iorio", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=22, Name = "Lonnie Schaff", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=23, Name = "Nelson Sater", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=24, Name = "Benita Arter", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=25, Name = "Julio Fallis", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=26, Name = "Tyrone Logiudice", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=27, Name = "Jessie Holoman", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=28, Name = "Julianne Dahlquist", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=29, Name = "Lakisha Rough", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Id=30, Name = "Dollie Lisby", Department = "IT", Deductions = RandomDeductions() },
			};
		}

		public void UpdateEmployees(string updates)
		{
			//not implemented yet
		}

		private static readonly Random _random = new Random(123);
		private IEnumerable<Deduction> RandomDeductions()
		{
			var types = new[] {"MEDICAL PRE-TAX", "DENTAL PRE-TAX", "VISION PRE-TAX", "PARKING", "SHOPPING", "MEAL TICKETS"};
			var available = _random.Next(1, types.Length);

			var result = new List<Deduction>();
			for (int i = 0; i < available; i++) {
				result.Add(new Deduction {Name = types[_random.Next(1, types.Length)], Amount = _random.Next(1,100), EmployerAmount = _random.Next(1,50)});
			}
			return result;
		}

		/// <summary>
		/// Consider for future.
		/// </summary>
		/// <param name="pageNumber"></param>
		/// <param name="pageSize"></param>
		/// <returns></returns>
		public PagedList<Employee> ListEmployees(int pageNumber, int pageSize)
		{
			return new PagedList<Employee>();
		}

		
	}
}