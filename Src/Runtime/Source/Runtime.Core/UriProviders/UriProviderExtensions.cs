﻿using System;
using System.Globalization;
using NuPattern.Runtime.Properties;

namespace NuPattern.Runtime.UriProviders
{
    /// <summary>
    /// Provides usability methods for uri provider consumers and authors.
    /// </summary>
    internal static class UriProviderExtensions
    {
        /// <summary>
        /// Throws <see cref="NotSupportedException"/> if the <see cref="Uri.Scheme"/> does 
        /// not match the <see cref="IUriReferenceProvider.UriScheme"/>.
        /// </summary>
        public static void ThrowIfNotSupportedUriScheme(this IUriReferenceProvider provider, Uri uri)
        {
            Guard.NotNull(() => provider, provider);
            Guard.NotNull(() => uri, uri);

            if (uri.Scheme != provider.UriScheme)
            {
                throw new NotSupportedException(string.Format(
                    CultureInfo.CurrentCulture,
                    Resources.UriProviderExtensions_WrongScheme,
                    provider.UriScheme));
            }
        }
    }
}
