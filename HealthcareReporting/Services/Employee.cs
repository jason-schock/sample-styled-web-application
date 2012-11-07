namespace HealthcareReporting.Services
{
	public class Employee
	{
		public long Id { get; set; }
		public string Ssn { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Department Department { get; set; }
		public DeductionSchema DeductionSchema { get; set; }

		public string Name
		{
			get { return LastName + ", " + FirstName; }
		}

		public string MaskedSsn
		{
			get
			{
				var mask = "xxx-xx-";
				return mask + Ssn.Substring(mask.Length + 1);
			}
		}

		public override string ToString()
		{
			return string.Format("{0} (ssn={1}) {2} {3}, adj. ${4}", Id, Ssn, LastName, FirstName, DeductionSchema.Adjustment);
		}
	}
}