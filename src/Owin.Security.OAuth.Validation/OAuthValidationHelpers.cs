﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Extensions for more information
 * concerning the license and the contributors participating to this project.
 */

using System;
using JetBrains.Annotations;
using Microsoft.Owin.Security;

namespace Owin.Security.OAuth.Validation
{
    /// <summary>
    /// Defines a set of commonly used helpers.
    /// </summary>
    internal static class OAuthValidationHelpers
    {
        /// <summary>
        /// Gets a given property from the authentication properties.
        /// </summary>
        /// <param name="properties">The authentication properties.</param>
        /// <param name="property">The specific property to look for.</param>
        /// <returns>The value corresponding to the property, or <c>null</c> if the property cannot be found.</returns>
        public static string GetProperty([NotNull] this AuthenticationProperties properties, [NotNull] string property)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            if (string.IsNullOrEmpty(property))
            {
                throw new ArgumentException("The property name cannot be null or empty.", nameof(property));
            }

            if (!properties.Dictionary.TryGetValue(property, out string value))
            {
                return null;
            }

            return value;
        }
    }
}
