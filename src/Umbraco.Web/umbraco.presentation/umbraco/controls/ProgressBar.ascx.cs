using System;

namespace umbraco.presentation.umbraco.controls
{
	public partial class ProgressBar : System.Web.UI.UserControl
	{
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);
			EnableViewState = false;
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			DataBind();
		}
	}
}