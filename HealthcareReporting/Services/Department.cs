namespace HealthcareReporting.Services
{
	public class Department
	{
		public string DivisionCode { get; set; }
		public string BusinessUnitCode { get; set; }
		public string DepartmentCode { get; set; }
		public string Description { get; set; }

		public override string ToString()
		{
			return string.Format("{0}/{1}/{2} - {3}", DivisionCode, BusinessUnitCode, DepartmentCode, Description);
		}
	}
}