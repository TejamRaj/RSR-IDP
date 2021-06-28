


using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace RSR.IDP
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "fec0a4d6-5830-4eb8-8024-272bd5d6d2bb",
                    Username = "RedSoilNerd",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "rajendra"),
                        new Claim("family_name", "tejam"),
                        new Claim("role", "user"),
                    }
                },
                new TestUser
                {
                    SubjectId = "c3b7f625-c07f-4d7d-9be1-ddff8ff93b4d",
                    Username = "Sven",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "rajendra"),
                        new Claim("family_name", "tejam"),
                        new Claim("role", "admin"),
                    }
                },
                new TestUser
                {
                    SubjectId = "c3b7f625-c07f-4d7d-9be1-ddff8ff93b4d",
                    Username = "GoaTourism",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "GoaTourism"),
                        new Claim("family_name", "Goa"),
                        new Claim("role", "SpaceProvider"),
                    }
                }
            };
        }

        public static List<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
               new IdentityResources.OpenId(),
               new IdentityResources.Profile(),
               new IdentityResource("roles", "Your role(s)", new []{"role"}),
            };
        }

        internal static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource("workplaceontourapi", "workplaceontour API")
                {
                    Scopes = new List<string>()
                    {
                        "workplaceontourapi.access"
                    }

                }
            };    
          
        }


        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                // backward compat
                new ApiScope("workplaceontourapi")
            };
        }



        // register sign in authority
        public static List<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "wpt-webclient",
                    ClientId="wpt-webclient",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequireConsent = false,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris =new List<string>
                    {
                        "https://localhost:4200/signin-oidc",
                        "https://localhost:4200/redirect-silentrenew"
                    },
                    AccessTokenLifetime = 180,
                    PostLogoutRedirectUris = new[]{
                        "https://localhost:4200/" },
                    AllowedScopes = new []
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        "workplaceontourapi",
                        "role",
                        "country"
                        
                    }
                }
            };
        }
    }
}