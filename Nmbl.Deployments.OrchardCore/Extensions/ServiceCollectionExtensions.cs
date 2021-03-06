using System;
using Microsoft.Extensions.DependencyInjection;
using Nmbl.Deployments.Core.Extensions;
using Nmbl.Deployments.Core.Models;
using Nmbl.Deployments.OrchardCore.ContentHandlers;
using Nmbl.Deployments.OrchardCore.Models;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.Security.Permissions;

namespace Nmbl.Deployments.OrchardCore.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddOrchardDeployments(
            this IServiceCollection services,
            Action<OrchardDeploymentOptions> orchardSetup = null,
            Action<DeploymentOptions> deploymentSetup = null
        ) {
            if (orchardSetup != null)
            {
                services.Configure(orchardSetup);
            }
            services.AddDeployments(deploymentSetup);

            services.AddLazyCache();
            services.AddSingleton<DeploymentStatus>();
            services.AddScoped<IContentHandler, DeployingContentHandler>();
            services.AddScoped<IPermissionProvider, Permissions>();
        }
    }
}
