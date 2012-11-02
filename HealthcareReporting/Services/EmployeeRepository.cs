using System;
using System.Collections.Generic;
using System.Linq;

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
				new Employee { Ssn="515-30-5411", Name = "Jeanie Holtzclaw", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5412", Name = "Eve Pickrell", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5413", Name = "Kelly Laffin", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5414", Name = "Neil Gauger", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5415", Name = "Tia Ulrey", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5416", Name = "Nita Batterton", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5417", Name = "Hugh Caufield", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5418", Name = "Allan Shanley", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5419", Name = "Allyson Ogg", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5420", Name = "Gay Finneran", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5421", Name = "Clayton Buesing", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5422", Name = "Jessie Quisenberry", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5423", Name = "Tania Lichty", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5424", Name = "Lonnie Hirth", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5425", Name = "Mathew Ridder", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5426", Name = "Clayton Hillin", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5427", Name = "Darren Lowy", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5428", Name = "Max Texeira", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5429", Name = "Melisa Litt", Department = "HR", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5430", Name = "Sofia Ishibashi", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5431", Name = "Annabelle Iorio", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5432", Name = "Lonnie Schaff", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5433", Name = "Nelson Sater", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5434", Name = "Benita Arter", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5435", Name = "Julio Fallis", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5436", Name = "Tyrone Logiudice", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5437", Name = "Jessie Holoman", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5438", Name = "Julianne Dahlquist", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5439", Name = "Lakisha Rough", Department = "IT", Deductions = RandomDeductions() },
				new Employee { Ssn="515-30-5440", Name = "Dollie Lisby", Department = "IT", Deductions = RandomDeductions() },
			};
		}

		public void UpdateEmployees(string updates)
		{
			//not implemented yet
		}

		private static readonly Random _random = new Random(123);
		private IEnumerable<Deduction> RandomDeductions()
		{
			var deductions = new DeductionPlansRepository().ListDeductions().ToList();
			var available = _random.Next(1, deductions.Count);

			var result = new List<Deduction>();
			for (int i = 0; i < available; i++) {
				result.Add(new Deduction {Name = deductions[_random.Next(1, deductions.Count)].Name, Amount = _random.Next(1,100), EmployerAmount = _random.Next(1,50)});
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