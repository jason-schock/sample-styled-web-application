using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using HealthcareReporting.Services;

namespace HealthcareReporting
{
	public partial class Selector : UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack) {
				lstAvailable.DataSource = new DeductionPlansRepository().ListDeductions();
				lstAvailable.DataValueField = "Id";
				lstAvailable.DataTextField = "Name";
				lstAvailable.DataBind();
			}
		}

		protected void ButtonAdd_Click(object sender, EventArgs e)
		{
			MoveItems(lstAvailable, lstSelected);
		}

		protected void ButtonRemove_Click(object sender, EventArgs e)
		{
			MoveItems(lstSelected, lstAvailable);
		}

		protected void ButtonAddAll_Click(object sender, EventArgs e)
		{
			MoveItems(lstAvailable, lstSelected, true); 
		}

		protected void ButtonRemoveAll_Click(object sender, EventArgs e)
		{
			MoveItems(lstSelected, lstAvailable, true);
		}

		private void MoveItems(ListBox from, ListBox to, bool all = false)
		{
			for (int i = from.Items.Count - 1; i >= 0; i--) {
				if (all || from.Items[i].Selected) {
					to.Items.Add(from.Items[i]);
					to.ClearSelection();
					from.Items.Remove(from.Items[i]);
				}
			}
		}
	}
}