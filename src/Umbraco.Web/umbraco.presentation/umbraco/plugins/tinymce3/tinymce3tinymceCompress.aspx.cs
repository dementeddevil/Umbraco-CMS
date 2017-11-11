using System;

namespace umbraco.presentation.plugins.tinymce3
{
    public partial class tinymce3tinymceCompress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            new GzipModule().ProcessRequest(this.Context);
        }
    }
}
