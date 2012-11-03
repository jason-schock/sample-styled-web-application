using System.Collections.Generic;
using System.Linq;

namespace HealthcareReporting.Services
{
	/// <summary>
	/// Deduction schema for an employeee in the given year.
	/// </summary>
	public class DeductionSchema
	{
		public int Year { get; set; }
		public IEnumerable<Deduction> Deductions { get; set; }
		public decimal Adjustment { get; set; }

		public decimal TotalDeduction
		{
			get { return (Deductions == null) ? 0 : Deductions.Sum(x => x.Amount + x.EmployerAmount); }
		}

		public decimal Total
		{
			get { return TotalDeduction + Adjustment; }
		}
	}
}