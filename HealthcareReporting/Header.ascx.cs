using System;
using System.Web.UI;

namespace HealthcareReporting
{
	public partial class Header : UserControl
	{
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public bool ShowLegend { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!ShowLegend) {
				legend.Attributes.Add("style", "display:none");
			}
		}
	}
}