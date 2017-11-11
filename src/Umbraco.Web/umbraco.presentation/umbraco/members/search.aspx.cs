using umbraco.BusinessLogic;

namespace umbraco.presentation.members
{


    public partial class search : BasePages.UmbracoEnsuredPage
    {
        public search()
        {
            CurrentApp = DefaultApps.member.ToString();
        }
    }
}
