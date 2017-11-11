using System;
using umbraco.businesslogic;
using Umbraco.Core;


namespace umbraco
{
	/// <summary>
	/// Handles loading of python items into the developer application tree
	/// </summary>
	[Obsolete("This tree is no longer shipped by default, it will be removed in the future")]
    [Tree(Constants.Applications.Developer, "python", "Python Files", sortOrder: 4)]
    public class loadPython : loadDLRScripts
	{
        public loadPython(string application) : base(application) { }
    }
    
}
