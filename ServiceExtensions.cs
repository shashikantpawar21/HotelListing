using System;
using System.Collections.Generic;
using System.Text;
using HotelListing.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace HotelListing
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<ApiUser>(q=>q.User.RequireUniqueEmail = true);
            builder = new IdentityBuilder(builder.UserType, services);
            builder.AddRoles<IdentityRole>();
            builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("Jwt");
            var jwtKey = Environment.GetEnvironmentVariable("JWT_KEY");

            services.AddAuthentication(o => {
                o.DefaultAuthenticateScheme =JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme =JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.GetSection("Issuer").Value,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
                    ValidateAudience = false
                };
            });
            services.AddAuthorization();

        }

        public static void AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddSwaggerGen(c=> 
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using Bearer scheme.
                    Enter 'Bearer' [space] and then your token in the text input below.
                    Example: 'Bearer 1234erwe",
                    Name= "Authorization",
                    In= ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference =  new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id= "Bearer"
                            },
                            Scheme ="oauth2",
                            Name="Bearer",
                            In= ParameterLocation.Header
                        }, 
                        new List<string>()
                    }
                });
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelListing", Version = "v1" });
            });

        }
    }
}