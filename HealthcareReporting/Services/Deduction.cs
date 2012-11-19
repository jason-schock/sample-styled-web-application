namespace HealthcareReporting.Services
{
	/// <summary>
	/// Single deduction.
	/// </summary>
	public class Deduction
	{
		/// <summary>
		/// Deduction ID in the database.
		/// </summary>
		public long Id { get; set; } 

		/// <summary>
		/// Name of the deduction ("DENTAL PRE-TAX" etc).
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Employee amount.
		/// </summary>
		public decimal Amount { get; set; }

		/// <summary>
		/// Employer amount.
		/// </summary>
		public decimal EmployerAmount { get; set; }
	}
}