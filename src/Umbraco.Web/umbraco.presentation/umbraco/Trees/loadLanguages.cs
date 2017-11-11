﻿using System;
using System.Text;
using umbraco.cms.businesslogic.language;
using umbraco.cms.presentation.Trees;


namespace umbraco
{
    [Obsolete("This is no longer used and will be removed from the codebase in the future")]
    //[Tree(Constants.Applications.Settings, "languages", "Languages", sortOrder: 4)]
    public class loadLanguages : BaseTree
	{
        public loadLanguages(string application) : base(application) { }

       protected override void CreateRootNode(ref XmlTreeNode rootNode)
        {   
            rootNode.NodeType = "init" + TreeAlias;
            rootNode.NodeID = "init";
        }

		public override void RenderJS(ref StringBuilder Javascript)
        {
            Javascript.Append(
                @"
function openLanguage(id) {
	UmbClientMgr.contentFrame('settings/editLanguage.aspx?id=' + id);
}");
        }

        public override void Render(ref XmlTree tree)
        {
            foreach (Language l in Language.getAll)
            {
                XmlTreeNode xNode = XmlTreeNode.Create(this);
                xNode.NodeID = l.id.ToString(); //"language_" + l.id.ToString();
                xNode.Text = l.FriendlyName;
                xNode.Action = "javascript:openLanguage(" + l.id + ");";
                xNode.Icon = "icon-flag-alt";
                xNode.OpenIcon = "icon-flag-alt";

                OnBeforeNodeRender(ref tree, ref xNode, EventArgs.Empty);
                if (xNode != null)
                {
                    tree.Add(xNode);
                    OnAfterNodeRender(ref tree, ref xNode, EventArgs.Empty);
                }
                
            }
        }

	}
    
}
