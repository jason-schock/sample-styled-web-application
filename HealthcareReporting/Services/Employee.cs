namespace HealthcareReporting.Services
{
	public class Employee
	{
		public string Ssn { get; set; }
		public string Name { get; set; }
		public string Department { get; set; }
		public DeductionSchema DeductionSchema { get; set; }

		public override string ToString()
		{
			return "(" + Ssn + ") " + Name + ", adj. $" + DeductionSchema.Adjustment;
		}
	}
}