using System;

namespace umbraco.presentation.umbraco.dialogs {
    public partial class insertMasterpagePlaceholder : BasePages.UmbracoEnsuredPage {

        public insertMasterpagePlaceholder()
        {
            CurrentApp = BusinessLogic.DefaultApps.settings.ToString();
        }
        protected void Page_Load(object sender, EventArgs e) {
            //labels
            pp_placeholder.Text = ui.Text("placeHolderID");
           
        }
    }
}
