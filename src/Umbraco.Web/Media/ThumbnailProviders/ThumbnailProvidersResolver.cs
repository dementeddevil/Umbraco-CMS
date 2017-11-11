﻿using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Logging;
using Umbraco.Core.Media;
using Umbraco.Core.ObjectResolution;

namespace Umbraco.Web.Media.ThumbnailProviders
{
    [Obsolete("Thumbnails are generated by ImageProcessor, use that instead")]
    public sealed class ThumbnailProvidersResolver : LazyManyObjectsResolverBase<ThumbnailProvidersResolver, IThumbnailProvider>
    {
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    /// <param name="serviceProvider"></param>
	    /// <param name="logger"></param>
	    /// <param name="providers"></param>		
	    internal ThumbnailProvidersResolver(IServiceProvider serviceProvider, ILogger logger, Func<IEnumerable<Type>> providers)
            : base(serviceProvider, logger, providers)
		{

		}

		/// <summary>
		/// Return the providers
		/// </summary>
		public IEnumerable<IThumbnailProvider> Providers
		{
			get { return GetSortedValues(); }
		}

        public string GetThumbnailUrl(string fileUrl)
        {
            var provider = Providers.FirstOrDefault(x => x.CanProvideThumbnail(fileUrl));
            return provider != null ? provider.GetThumbnailUrl(fileUrl) : string.Empty;
        }

    }
}
