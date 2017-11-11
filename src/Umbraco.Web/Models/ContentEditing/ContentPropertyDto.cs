using Newtonsoft.Json;
using Umbraco.Core.Models;

namespace Umbraco.Web.Models.ContentEditing
{
    /// <summary>
    /// Represents a content property from the database
    /// </summary>
    internal class ContentPropertyDto : ContentPropertyBasic
    {
        public IDataTypeDefinition DataType { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; }
        public string ValidationRegExp { get; set; }

        /// <summary>
        /// The current pre-values for this property
        /// </summary>
        [JsonIgnore]
        internal PreValueCollection PreValues { get; set; }
    }
}