using System;
using umbraco.BasePages;
using umbraco.cms.presentation.Trees;

namespace umbraco.cms.presentation
{
    [Obsolete("This class is no longer used and will be removed in future versions. The page that supercedes this is Umbraco.Web.UI.Umbraco.TreeInit")]
    public partial class TreeInit : UmbracoEnsuredPage
    {

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TreeParams = TreeRequestParams.FromQueryStrings().CreateTreeService();
            DataBind();
        }

        protected TreeService TreeParams { get; private set; }

		/// <summary>
		/// Head1 control.
		/// </summary>
		/// <remarks>
		/// Auto-generated field.
		/// To modify move field declaration from designer file to code-behind file.
		/// </remarks>
		protected global::System.Web.UI.HtmlControls.HtmlHead Head1;

		/// <summary>
		/// ClientLoader control.
		/// </summary>
		/// <remarks>
		/// Auto-generated field.
		/// To modify move field declaration from designer file to code-behind file.
		/// </remarks>
		protected global::umbraco.uicontrols.UmbracoClientDependencyLoader ClientLoader;

		/// <summary>
		/// CssInclude1 control.
		/// </summary>
		/// <remarks>
		/// Auto-generated field.
		/// To modify move field declaration from designer file to code-behind file.
		/// </remarks>
		protected global::ClientDependency.Core.Controls.CssInclude CssInclude1;

		/// <summary>
		/// form1 control.
		/// </summary>
		/// <remarks>
		/// Auto-generated field.
		/// To modify move field declaration from designer file to code-behind file.
		/// </remarks>
		protected global::System.Web.UI.HtmlControls.HtmlForm form1;

		/// <summary>
		/// ScriptManager1 control.
		/// </summary>
		/// <remarks>
		/// Auto-generated field.
		/// To modify move field declaration from designer file to code-behind file.
		/// </remarks>
		protected global::System.Web.UI.ScriptManager ScriptManager1;

		/// <summary>
		/// JTree control.
		/// </summary>
		/// <remarks>
		/// Auto-generated field.
		/// To modify move field declaration from designer file to code-behind file.
		/// </remarks>
		protected global::umbraco.controls.Tree.TreeControl JTree;
    }
}