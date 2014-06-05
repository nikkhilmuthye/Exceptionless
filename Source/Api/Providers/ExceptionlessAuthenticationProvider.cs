﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;

namespace Exceptionless.Api {
    public class ExceptionlessAuthenticationProvider : OAuthBearerAuthenticationProvider {
        public override Task RequestToken(OAuthRequestTokenContext context) {
            context.Token = context.Request.Query.Get("access_token");
            return Task.FromResult(0);
        }

        public override Task ValidateIdentity(OAuthValidateIdentityContext context) {
            return Task.FromResult(0);
        }
    }
}