﻿using System;
using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.EntityFramework.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Forgebase.Identity.Configuration
{
    public class IdentityServer
    {
        private static IConfiguration _configuration;

        public IdentityServer(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        /// <summary>
        /// ApiResources define the APIs in your system
        /// </summary>
        /// <returns>
        /// List of ApiResources
        /// </returns>
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource()
                {
                    DisplayName = "Masterdata Service",
                    Name = "Masterdata",
                    Enabled = true,
                    ShowInDiscoveryDocument = true,
                    Created = new DateTime(2021, 3, 8, 11, 7, 29, 917, DateTimeKind.Utc).AddTicks(7870),
                    NonEditable = false,
                    Id = 1,
                },
            };
        }

        /// <summary>
        /// Identity resources are data like user id, name or email address of a user
        /// </summary>
        /// <returns>
        /// List of Identity Resources
        /// </returns>
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResource()
                {
                    Id = 1,
                    Enabled = true,
                    Name = "profile",
                    DisplayName = "User profile",
                    Description = "Your user profile information (first name, last name, etc.)",
                    Required = false,
                    Emphasize = true,
                    ShowInDiscoveryDocument = true,
                    Created = new DateTime(2021, 3, 8, 11, 7, 29, 917, DateTimeKind.Utc).AddTicks(7870),
                    NonEditable = false,

                },
                new IdentityResource()
                {
                    Id = 2,
                    Enabled = true,
                    Name = "openid",
                    DisplayName = "Your user identifier",
                    Description = null,
                    Required = true,
                    Emphasize = false,
                    ShowInDiscoveryDocument = true,
                    Created = new DateTime(2021, 3, 8, 11, 7, 29, 917, DateTimeKind.Utc).AddTicks(7870),
                    NonEditable = false,
                },
            };
        }

        /// <summary>
        /// API Scopes represent the scoped access
        /// </summary>
        /// <returns>List of Api Scopes</returns>
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope()
                {
                    Name = "Masterdata",
                    DisplayName = "Masterdata API Scope",
                    Enabled = true,
                    Required = false,
                    Emphasize = false,
                    ShowInDiscoveryDocument = true,
                    Id = 1,
                },
            };
        }

        public static IEnumerable<ApiResourceScope> GetApiResourceScopes()
        {
            return new List<ApiResourceScope>
            {
                new ApiResourceScope()
                {
                    Id = 1,
                    ApiResourceId = 1,
                    Scope = "Masterdata"
                }
            };
        }

        /// <summary>
        /// Identity Resource Claims mapped with IdenityResources
        /// </summary>
        /// <returns>List of Identity Resource Claims</returns>
        public static IEnumerable<IdentityResourceClaim> GetIdentityResourceClaims()
        {
            return new List<IdentityResourceClaim>
            {
                new IdentityResourceClaim()
                {
                    Id = 1,
                    IdentityResourceId = 1,
                    Type = "given_name"
                },
                new IdentityResourceClaim()
                {
                    Id = 2,
                    IdentityResourceId = 1,
                    Type = "family_name"
                },
                new IdentityResourceClaim()
                {
                    Id = 3,
                    IdentityResourceId = 1,
                    Type = "name"
                },
                new IdentityResourceClaim()
                {
                    Id = 4,
                    IdentityResourceId = 1,
                    Type = "middle_name"
                },
                new IdentityResourceClaim()
                {
                    Id = 5,
                    IdentityResourceId = 1,
                    Type = "nickname"
                },
                new IdentityResourceClaim()
                {
                    Id = 6,
                    IdentityResourceId = 1,
                    Type = "preferred_username"
                },
                new IdentityResourceClaim()
                {
                    Id = 7,
                    IdentityResourceId = 1,
                    Type = "profile"
                },
                new IdentityResourceClaim()
                {
                    Id = 8,
                    IdentityResourceId = 1,
                    Type = "picture"
                },
                new IdentityResourceClaim()
                {
                    Id = 9,
                    IdentityResourceId = 1,
                    Type = "website"
                },
                new IdentityResourceClaim()
                {
                    Id = 10,
                    IdentityResourceId = 1,
                    Type = "gender"
                },
                new IdentityResourceClaim()
                {
                    Id = 11,
                    IdentityResourceId = 1,
                    Type = "birthdate"
                },
                new IdentityResourceClaim()
                {
                    Id = 12,
                    IdentityResourceId = 1,
                    Type = "zoneinfo"
                },
                new IdentityResourceClaim()
                {
                    Id = 13,
                    IdentityResourceId = 1,
                    Type = "locale"
                },
                new IdentityResourceClaim()
                {
                    Id = 14,
                    IdentityResourceId = 1,
                    Type = "updated_at"
                },
                new IdentityResourceClaim()
                {
                    Id = 15,
                    IdentityResourceId = 2,
                    Type = "sub"
                },
            };

        }

        /// <summary>
        /// Gets configured list of Identity Server 4 clients
        /// </summary>
        /// <returns>List of IdServer4 Clients</returns>
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client()
                {
                    Id = 1,
                    Enabled = true,
                    ClientId = "forgebase-react",
                    ProtocolType = "oidc",
                    RequireClientSecret = true,
                    ClientName = "Forgebase React Frontend OpenId Client",
                    Description = null,
                    ClientUri = $"http://localhost:5003",
                    LogoUri = null,
                    RequireConsent = false,
                    AllowRememberConsent = true,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = true,
                    AllowPlainTextPkce = false,
                    RequireRequestObject = false,
                    AllowAccessTokensViaBrowser = true,
                    FrontChannelLogoutSessionRequired = true,
                    FrontChannelLogoutUri = null,
                    BackChannelLogoutSessionRequired = true,
                    BackChannelLogoutUri = null,
                    AllowOfflineAccess = false,
                    IdentityTokenLifetime = 300,
                    AllowedIdentityTokenSigningAlgorithms = null,
                    AccessTokenLifetime = 3600,
                    AuthorizationCodeLifetime = 300,
                    ConsentLifetime = null,
                    AbsoluteRefreshTokenLifetime = 2592000,
                    SlidingRefreshTokenLifetime = 1296000,
                    RefreshTokenUsage = 1,
                    UpdateAccessTokenClaimsOnRefresh = false,
                    RefreshTokenExpiration = 1,
                    AccessTokenType = 0,
                    EnableLocalLogin = true,
                    IncludeJwtId = true,
                    AlwaysSendClientClaims = false,
                    ClientClaimsPrefix = "client_",
                    PairWiseSubjectSalt = null,
                    Created = new DateTime(2021, 3, 8, 11, 7, 29, 917, DateTimeKind.Utc).AddTicks(7870),
                    Updated = null,
                    LastAccessed = null,
                    UserSsoLifetime = null,
                    UserCodeType = null,
                    DeviceCodeLifetime = 300,
                    NonEditable = false,
                },
                new Client()
                {
                    Id = 2,
                    Enabled = true,
                    ClientId = "forgebase-masterdata",
                    ProtocolType = "oidc",
                    RequireClientSecret = true,
                    ClientName = "Forgebase Masterdata Swagger UI",
                    Description = null,
                    ClientUri = null,
                    LogoUri = null,
                    RequireConsent = false,
                    AllowRememberConsent = true,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = true,
                    AllowPlainTextPkce = false,
                    RequireRequestObject = false,
                    AllowAccessTokensViaBrowser = true,
                    FrontChannelLogoutSessionRequired = true,
                    FrontChannelLogoutUri = null,
                    BackChannelLogoutSessionRequired = true,
                    BackChannelLogoutUri = null,
                    AllowOfflineAccess = false,
                    IdentityTokenLifetime = 300,
                    AllowedIdentityTokenSigningAlgorithms = null,
                    AccessTokenLifetime = 3600,
                    AuthorizationCodeLifetime = 300,
                    ConsentLifetime = null,
                    AbsoluteRefreshTokenLifetime = 2592000,
                    SlidingRefreshTokenLifetime = 1296000,
                    RefreshTokenUsage = 1,
                    UpdateAccessTokenClaimsOnRefresh = false,
                    RefreshTokenExpiration = 1,
                    AccessTokenType = 0,
                    EnableLocalLogin = true,
                    IncludeJwtId = true,
                    AlwaysSendClientClaims = false,
                    ClientClaimsPrefix = "client_",
                    PairWiseSubjectSalt = null,
                    Created = new DateTime(2021, 3, 8, 11, 7, 29, 917, DateTimeKind.Utc).AddTicks(7870),
                    Updated = null,
                    LastAccessed = null,
                    UserSsoLifetime = null,
                    UserCodeType = null,
                    DeviceCodeLifetime = 300,
                    NonEditable = false,
                }
            };
        }

        /// <summary>
        /// Adds Cors Origin to Clients
        /// </summary>
        /// <returns>List of ClientCorsOrigin entities</returns>
        public static IEnumerable<ClientCorsOrigin> GetClientCorsOrigins()
        {
            return new List<ClientCorsOrigin>
            {
                new ClientCorsOrigin()
                {
                    Id = 1,
                    ClientId = 1,
                    Origin = $"http://localhost:5003"
                }
            };
        }

        /// <summary>
        /// Maps Client Scopes with configured clients
        /// </summary>
        /// <returns>List of ClientScope entities.</returns>
        public static IEnumerable<ClientScope> GetClientScopes()
        {
            return new List<ClientScope>()
            {
                new ClientScope()
                {
                    Id = 1,
                    ClientId = 1,
                    Scope = IdentityServerConstants.StandardScopes.OpenId
                },

                new ClientScope()
                {
                    Id = 2,
                    ClientId = 1,
                    Scope = IdentityServerConstants.StandardScopes.Profile
                },
                new ClientScope()
                {
                    Id = 3,
                    ClientId = 1,
                    Scope = "Masterdata"
                },
                new ClientScope()
                {
                    Id = 4,
                    ClientId = 2,
                    Scope = "Masterdata"
                }

            };
        }

        /// <summary>
        /// Adds Grant Types to clients
        /// </summary>
        /// <returns>List of ClientGrantType entities.</returns>
        public static IEnumerable<ClientGrantType> GetClientGrantTypes()
        {
            return new List<ClientGrantType>
            {
                new ClientGrantType()
                {
                    Id = 1,
                    ClientId = 1,
                    GrantType = "implicit"
                },
                new ClientGrantType()
                {
                    Id = 2,
                    ClientId = 2,
                    GrantType = "implicit"
                },

            };
        }

        /// <summary>
        /// Adds Post RedirectUri to Clients
        /// </summary>
        /// <returns>List of ClientPostLogoutRedirectUri entities</returns>
        public static IEnumerable<ClientPostLogoutRedirectUri> GetClientPostLogoutRedirectUris()
        {
            return new List<ClientPostLogoutRedirectUri>
            {
                new ClientPostLogoutRedirectUri()
                {
                    Id = 1,
                    ClientId = 1,
                    PostLogoutRedirectUri = $"http://localhost:5003/"
                },
                new ClientPostLogoutRedirectUri()
                {
                    Id = 2,
                    ClientId = 2,
                    PostLogoutRedirectUri = $"http://localhost:5002/swagger/"
                }
            };
        }

        /// <summary>
        /// Adds Client RedirectUri to Clients
        /// </summary>
        /// <returns>List of ClientRedirectUri entities</returns>
        public static IEnumerable<ClientRedirectUri> GetClientRedirectUris()
        {
            return new List<ClientRedirectUri>
            {
                new ClientRedirectUri()
                {
                    Id = 1,
                    ClientId = 1,
                    RedirectUri = $"http://localhost:5003/"
                },
                new ClientRedirectUri()
                {
                    Id = 2,
                    ClientId = 2,
                    RedirectUri = $"http://localhost:5002/swagger/oauth2-redirect.html"
                }
            };

        }
    }
}
