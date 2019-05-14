﻿using Umbraco.Core;
using Umbraco.Core.PropertyEditors;

namespace Umbraco.Web.PropertyEditors
{
    [PropertyEditor(Constants.PropertyEditors.MemberGroupPickerAlias, "Member Group Picker", PropertyEditorValueTypes.Text, "membergrouppicker", Group="People", Icon="icon-users")]
    public class MemberGroupPickerPropertyEditor : PropertyEditor
    {
    }
}
