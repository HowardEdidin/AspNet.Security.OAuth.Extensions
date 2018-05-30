﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Extensions for more information
 * concerning the license and the contributors participating to this project.
 */

using JetBrains.Annotations;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Notifications;

namespace Owin.Security.OAuth.Validation
{
    /// <summary>
    /// Allows custom decryption of access tokens.
    /// </summary>
    public class DecryptTokenContext : BaseNotification<OAuthValidationOptions>
    {
        public DecryptTokenContext(
            [NotNull] IOwinContext context,
            [NotNull] OAuthValidationOptions options,
            [NotNull] string token)
            : base(context, options)
        {
            Token = token;
        }

        /// <summary>
        /// Gets the access token.
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// Gets or sets the data format used to deserialize the authentication ticket.
        /// </summary>
        public ISecureDataFormat<AuthenticationTicket> DataFormat { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="AuthenticationTicket"/>
        /// extracted from the access token.
        /// </summary>
        public AuthenticationTicket Ticket { get; set; }
    }
}
