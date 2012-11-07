using System;
using System.Web.Services;
using System.Web.UI;
using HealthcareReporting.Services;

namespace HealthcareReporting
{
	public partial class MapDeductionsPlans : Page
	{
		[WebMethod]
		public static void Save(string updates)
		{
			new DeductionPlansRepository().UpdateDeductions(updates);
		}
	}
}