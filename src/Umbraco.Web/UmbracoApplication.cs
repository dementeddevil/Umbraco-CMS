using System;
using System.IO;
using Umbraco.Core;
using Umbraco.Core.Configuration;
using Umbraco.Core.IO;
using Umbraco.Core.Logging;
using Umbraco.Core.Manifest;

namespace Umbraco.Web
{
	/// <summary>
	/// The Umbraco global.asax class
	/// </summary>
    public class UmbracoApplication : UmbracoApplicationBase
	{
	    private ManifestWatcher _mw;

	    protected override void OnApplicationStarted(object sender, EventArgs e)
	    {
	        base.OnApplicationStarted(sender, e);

	        if (ApplicationContext.Current.IsConfigured && GlobalSettings.DebugMode)
	        {                   
	            var appPluginFolder = IOHelper.MapPath("~/App_Plugins/");
	            if (Directory.Exists(appPluginFolder))
	            {
                        _mw = new ManifestWatcher(LoggerResolver.Current.Logger);
                        _mw.Start(Directory.GetDirectories(appPluginFolder));
                    }
	        }
	    }

	    protected override void OnApplicationEnd(object sender, EventArgs e)
	    {
	        base.OnApplicationEnd(sender, e);

	        if (_mw != null)
	        {
                _mw.Dispose();    
	        }
	    }

	    protected override IBootManager GetBootManager()
	    {
            return new WebBootManager(this);	        
	    }
	}
}
