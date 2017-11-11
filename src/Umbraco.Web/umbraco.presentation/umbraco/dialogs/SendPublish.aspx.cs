using System;
using Umbraco.Web;
using umbraco.BusinessLogic;
using umbraco.BusinessLogic.Actions;

namespace umbraco.dialogs
{
	/// <summary>
	/// Runs all action handlers for the ActionToPublish action for the document with
    /// the corresponding document id passed in by query string
	/// </summary>
	public partial class SendPublish : BasePages.UmbracoEnsuredPage
	{
	    public SendPublish()
	    {
	        CurrentApp = DefaultApps.content.ToString();
	    }

		protected void Page_Load(object sender, EventArgs e)
		{
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                int docId;
                if (int.TryParse(Request.QueryString["id"], out docId))
                {
                    //send notifications! TODO: This should be put somewhere centralized instead of hard coded directly here
                    ApplicationContext.Services.NotificationService.SendNotification(
                        ApplicationContext.Services.ContentService.GetById(docId), ActionToPublish.Instance, ApplicationContext);
                }

            }
            
		}

		
	}
}
