using System;
using System.Collections.Generic;
using System.Web.UI;
using HealthcareReporting.Services;

namespace HealthcareReporting
{
	public partial class Popup : UserControl
	{
		public IEnumerable<Deduction> Deductions { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			BindData();
		}

		internal void BindData()
		{
			gvPopup.DataSource = Deductions;
			gvPopup.DataBind();
		}
	}
}