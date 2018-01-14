using Umbraco.Core;
using Umbraco.Core.PropertyEditors;

namespace Umbraco.Web.PropertyEditors
{
    [PropertyEditor(Constants.PropertyEditors.TextboxAlias, "Textbox", "textbox", IsParameterEditor = true, Group = "Common")]
    public class TextboxPropertyEditor : PropertyEditor
    {
        protected override PropertyValueEditor CreateValueEditor()
        {
            return new TextOnlyValueEditor(base.CreateValueEditor());
        }

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new TextboxPreValueEditor();
        }

        internal class TextboxPreValueEditor : PreValueEditor
        {
            [PreValueField("maxChars", "Maximum allowed characters", "textstringlimited", Description = "If empty - 500 character limit")]
            public bool MaxChars { get; set; }
        }
    }
}
