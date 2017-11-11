using Umbraco.Web.UI;
using umbraco.BusinessLogic;

namespace umbraco
{
    public class languageTasks : LegacyDialogTask
    {
       
        public override bool PerformSave()
        {
            cms.businesslogic.language.Language.MakeNew(Alias);
            return true;
        }

        public override bool PerformDelete()
        {
            new cms.businesslogic.language.Language(ParentID).Delete();
            return false;
        }

        public override string ReturnUrl
        {
            get { return string.Empty; }
        }

        public override string AssignedApp
        {
            get { return DefaultApps.settings.ToString(); }
        }
    }

}
