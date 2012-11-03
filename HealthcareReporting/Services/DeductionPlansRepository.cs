using System.Collections.Generic;

namespace HealthcareReporting.Services
{
	public class DeductionPlansRepository
	{
		public IEnumerable<Deduction> ListDeductions()
		{
			return DeductionPlansRepositoryHardcoded.Deductions;
		}

		public void UpdateDeductions(string updates)
		{
			//throw new NotImplementedException();
		}
	}
}