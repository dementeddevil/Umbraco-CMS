using umbraco.interfaces;

namespace Umbraco.Web.WebApi
{
    /// <summary>
    /// The base class for auto-routed API controllers for Umbraco
    /// </summary>
    public abstract class UmbracoApiController : UmbracoApiControllerBase, IDiscoverable
    {        
        protected UmbracoApiController()
        {
        }

        protected UmbracoApiController(UmbracoContext umbracoContext) : base(umbracoContext)
        {
        }

        protected UmbracoApiController(UmbracoContext umbracoContext, UmbracoHelper umbracoHelper) : base(umbracoContext, umbracoHelper)
        {
        }
    }
}
