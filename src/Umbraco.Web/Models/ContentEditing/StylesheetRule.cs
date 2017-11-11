﻿using System.Runtime.Serialization;

namespace Umbraco.Web.Models.ContentEditing
{
    [DataContract(Name = "stylesheetRule", Namespace = "")]
    public class StylesheetRule
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "selector")]
        public string Selector { get; set; }

    }
}
