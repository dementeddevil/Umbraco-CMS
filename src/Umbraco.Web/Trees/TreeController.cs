﻿namespace Umbraco.Web.Trees
{
    /// <summary>
    /// The base controller for all tree requests
    /// </summary>
    public abstract class TreeController : TreeControllerBase
    {
        private TreeAttribute _attribute;

        protected TreeController()
        {
            Initialize();
        }

        protected TreeController(UmbracoContext umbracoContext) : base(umbracoContext)
        {
            Initialize();
        }

        protected TreeController(UmbracoContext umbracoContext, UmbracoHelper umbracoHelper) : base(umbracoContext, umbracoHelper)
        {
            Initialize();
        }        

        /// <summary>
        /// The name to display on the root node
        /// </summary>
        public override string RootNodeDisplayName
        {
            get { return _attribute.GetRootNodeDisplayName(Services.TextService); }
        }

        /// <summary>
        /// Gets the current tree alias from the attribute assigned to it.
        /// </summary>
        public override string TreeAlias
        {
            get { return _attribute.Alias; }
        }

        private void Initialize()
        {
            _attribute = GetType().GetTreeAttribute();
        }
    }
}
