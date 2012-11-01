using System.Collections.Generic;
using System.Linq;

namespace HealthcareReporting.Services
{
	public class Employee
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Department { get; set; }
		public IEnumerable<Deduction> Deductions { get; set; }
		public decimal Adjustment { get; set; }
		
		public decimal Deduction
		{
			get { return (Deductions == null) ? 0 : Deductions.Sum(x => x.Amount + x.EmployerAmount); }
		}

		public decimal Total
		{
			get { return Deduction + Adjustment;  }
		}
	}
}