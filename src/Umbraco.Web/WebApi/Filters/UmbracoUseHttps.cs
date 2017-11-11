using System;
using System.ComponentModel;

namespace Umbraco.Web.WebApi.Filters
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use the filter Umbraco.Web.Mvc.UmbracoRequireHttpsAttribute instead, this one is in the wrong namespace")]
    public class UmbracoUseHttps : Umbraco.Web.Mvc.UmbracoRequireHttpsAttribute
    {
    }
}
