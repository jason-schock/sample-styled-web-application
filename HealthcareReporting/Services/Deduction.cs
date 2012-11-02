namespace HealthcareReporting.Services
{
	public class Deduction
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public decimal Amount { get; set; } //to avoid "employeE - employeR" typing mistakes 
		public decimal EmployerAmount { get; set; }
	}
}