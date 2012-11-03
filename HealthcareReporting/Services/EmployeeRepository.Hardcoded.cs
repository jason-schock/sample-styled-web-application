using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareReporting.Services
{
	internal static class EmployeeRepositoryHardcoded
	{
		/// <summary>
		/// Hardcoded one - in the real app will return all employees.
		/// </summary>
		/// <value></value>
		internal static IEnumerable<Employee> Employees
		{
			get
			{
				return new List<Employee> {
					new Employee {Ssn = "515-30-5411", Name = "Jeanie Holtzclaw", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5413", Name = "Kelly Laffin", Department = "HR", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5414", Name = "Neil Gauger", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5415", Name = "Tia Ulrey", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5416", Name = "Nita Batterton", Department = "HR", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5417", Name = "Hugh Caufield", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5418", Name = "Allan Shanley", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5419", Name = "Allyson Ogg", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5420", Name = "Gay Finneran", Department = "HR", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5421", Name = "Clayton Buesing", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5422", Name = "Jessie Quisenberry", Department = "HR", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5423", Name = "Tania Lichty", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5424", Name = "Lonnie Hirth", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5425", Name = "Mathew Ridder", Department = "HR", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5426", Name = "Clayton Hillin", Department = "HR", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5427", Name = "Darren Lowy", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5428", Name = "Max Texeira", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5429", Name = "Melisa Litt", Department = "HR", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5430", Name = "Sofia Ishibashi", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5431", Name = "Annabelle Iorio", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5432", Name = "Lonnie Schaff", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5433", Name = "Nelson Sater", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5434", Name = "Benita Arter", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5435", Name = "Julio Fallis", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5436", Name = "Tyrone Logiudice", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5437", Name = "Jessie Holoman", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5438", Name = "Julianne Dahlquist", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5439", Name = "Lakisha Rough", Department = "IT", DeductionSchema = RandomPlan()},
					new Employee {Ssn = "515-30-5440", Name = "Dollie Lisby", Department = "IT", DeductionSchema = RandomPlan()},
				};
			}
		}

		internal static IEnumerable<EmployeeIdType> EployeeIdTypes
		{
			get
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

		private static readonly Random _random = new Random(123);
		private static DeductionSchema RandomPlan()
		{
			var deductions = new DeductionPlansRepository().ListDeductions().ToList();
			var selected = _random.Next(1, deductions.Count);

			var result = new List<Deduction>();
			for (int i = 0; i < selected; i++) {
				result.Add(new Deduction {Name = deductions[_random.Next(1, deductions.Count)].Name, Amount = _random.Next(1,100), EmployerAmount = _random.Next(1,50)});
			}
			
			return new DeductionSchema {
				Adjustment = 0,
				Deductions = result,
				Year = 2012
			};
		}
	}
}