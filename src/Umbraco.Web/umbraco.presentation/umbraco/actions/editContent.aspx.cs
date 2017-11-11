using System;

namespace umbraco.presentation.actions
{

    /// <summary>
    /// This page is used only to deeplink to the edit content page with the tree
    /// </summary>
    public partial class editContent : BasePages.UmbracoEnsuredPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("../umbraco.aspx?app=content&rightAction=editContent&id=" + helper.Request("id") + "#content", true);
        }
    }
}
