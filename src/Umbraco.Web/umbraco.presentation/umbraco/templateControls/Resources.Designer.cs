﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umbraco.Web.umbraco.presentation.umbraco.templateControls {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Umbraco.Web.umbraco.presentation.umbraco.templateControls.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;!DOCTYPE xsl:stylesheet [ &lt;!ENTITY nbsp &quot;&amp;#x00A0;&quot;&gt; ]&gt;
        ///&lt;xsl:stylesheet 
        ///	version=&quot;1.0&quot; 
        ///	xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; 
        ///	xmlns:msxml=&quot;urn:schemas-microsoft-com:xslt&quot;
        ///	xmlns:umbraco.library=&quot;urn:umbraco.library&quot;
        ///  {3}
        ///	exclude-result-prefixes=&quot;msxml umbraco.library {2}&quot;&gt;
        ///&lt;xsl:output method=&quot;xml&quot; omit-xml-declaration=&quot;yes&quot;/&gt;
        ///&lt;xsl:param name=&quot;currentPage&quot;/&gt;
        ///&lt;xsl:param name=&quot;itemData&quot;/&gt;
        ///&lt;xsl:template match=&quot;/&quot;&gt;&lt;xsl:value-of select=&quot;{0}&quot; disa [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InlineXslt {
            get {
                return ResourceManager.GetString("InlineXslt", resourceCulture);
            }
        }
    }
}
