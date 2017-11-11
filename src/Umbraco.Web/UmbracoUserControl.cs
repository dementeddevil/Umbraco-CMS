using System;

namespace Umbraco.Web
{
    /// <summary>
    /// A base class for all Presentation UserControls to inherit from
    /// </summary>
    [Obsolete("Use the Umbraco.Web.UI.Controls.UmbracoUserControl instead")]
    public abstract class UmbracoUserControl : Umbraco.Web.UI.Controls.UmbracoUserControl
    {
         /// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="umbracoContext"></param>
		protected UmbracoUserControl(UmbracoContext umbracoContext)
            : base(umbracoContext)
		{
            
		}

		/// <summary>
		/// Empty constructor, uses Singleton to resolve the UmbracoContext
		/// </summary>
        protected UmbracoUserControl()
			: base()
		{			
		}

    }
}