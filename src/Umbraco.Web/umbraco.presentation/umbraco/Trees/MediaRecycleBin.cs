using System;
using System.Collections.Generic;
using System.Text;
using umbraco.cms.businesslogic;
using umbraco.cms.businesslogic.media;
using umbraco.interfaces;
using umbraco.BusinessLogic.Actions;


namespace umbraco.cms.presentation.Trees
{
    [Obsolete("This is no longer used and will be removed from the codebase in the future")]
	public class MediaRecycleBin : BaseMediaTree
	{
		public MediaRecycleBin(string application) : base(application) { }

		protected override void CreateRootNodeActions(ref List<IAction> actions)
		{
			actions.Clear();
			actions.Add(ActionEmptyTranscan.Instance);
			actions.Add(ContextMenuSeperator.Instance);
			actions.Add(ActionRefresh.Instance);
		}

		protected override void CreateAllowedActions(ref List<IAction> actions)
		{
			actions.Clear();
			actions.Add(ActionMove.Instance);
			actions.Add(ContextMenuSeperator.Instance);
			actions.Add(ActionDelete.Instance);
			actions.Add(ContextMenuSeperator.Instance);
			actions.Add(ActionRefresh.Instance);
		}

		/// <summary>
		/// By default the Recycle bin start node is -21
		/// </summary>
		public override int StartNodeID
		{
			get
			{
				return (int)RecycleBin.RecycleBinType.Media;
			}
		}

        /// <summary>
        /// Override the render js so no duplicate js is rendered.
        /// </summary>
        /// <param name="Javascript"></param>
        public override void RenderJS(ref StringBuilder Javascript) { }

		protected override void CreateRootNode(ref XmlTreeNode rootNode)
		{
			rootNode.Icon = "bin_empty.png";
			rootNode.OpenIcon = "bin.png";
			//we made this alias the same as media, so the node name would be media,
			//we need to make it recycle bin
			TreeDefinition treeDef = TreeDefinitionCollection.Instance.FindTree(this);
			rootNode.Text = rootNode.Text = GetTreeHeader(treeDef.Tree.Alias);
			if (new RecycleBin(Media._objectType, RecycleBin.RecycleBinType.Media).Smells())
			{
				rootNode.Icon = "bin.png";
			}
			else
				rootNode.Source = null;
		}

		protected override void OnBeforeNodeRender(ref XmlTree sender, ref XmlTreeNode node, EventArgs e)
		{
			base.OnBeforeNodeRender(ref sender, ref node, e);
			node.Style.DimNode();
		}

	}
}
