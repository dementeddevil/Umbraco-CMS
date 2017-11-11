using System.Web.UI;
using Umbraco.Core.IO;

namespace umbraco.presentation.webservices
{
    public class ajaxHelpers
    {
        public static void EnsureLegacyCalls(Page page)
        {
            var sm = ScriptManager.GetCurrent(page);
            var legacyPath = new ServiceReference(SystemDirectories.WebServices + "/legacyAjaxCalls.asmx");

            if (!sm.Services.Contains(legacyPath))
                sm.Services.Add(legacyPath);
        }
    }
}
