using System.Net.Http;
using System.Web.Http.Filters;
using Umbraco.Web.Editors;

namespace Umbraco.Web.WebApi.Filters
{
    /// <summary>
    /// Used to emit outgoing editor model events
    /// </summary>
    internal sealed class OutgoingEditorModelEventAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Response == null) return;

            var user = UmbracoContext.Current.Security.CurrentUser;
            if (user == null) return;

            var objectContent = actionExecutedContext.Response.Content as ObjectContent;
            if (objectContent != null)
            {
                var model = objectContent.Value;

                if (model != null)
                {
                    EditorModelEventManager.EmitEvent(actionExecutedContext, new EditorModelEventArgs(
                        (dynamic)model,
                        UmbracoContext.Current));
                }
            }

            base.OnActionExecuted(actionExecutedContext);
        }        
    }
}