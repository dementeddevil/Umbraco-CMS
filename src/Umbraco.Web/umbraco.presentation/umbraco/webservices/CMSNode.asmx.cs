using System.Web.Script.Services;
using System.Web.Services;
using Umbraco.Web.WebServices;

namespace umbraco.presentation.webservices
{
    /// <summary>
    /// Summary description for CMSNode
    /// </summary>
    [WebService(Namespace = "http://umbraco.org/webservices/")]
    [ScriptService]
    public class CMSNode : UmbracoAuthorizedWebService
    {

        [WebMethod]
        public string GetNodeName(string ContextID, int NodeId)
        {
            return ValidateUserContextId(ContextID) 
                ? GetNodeName(NodeId) 
                : string.Empty;
        }

        private string GetNodeName(int nodeId)
        {
            if (!AuthorizeRequest()) return string.Empty;
            var n = new cms.businesslogic.CMSNode(nodeId);
            return n.Text;
        }
    }
}
