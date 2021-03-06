using Nmbl.Deployments.Core.Models;

namespace Nmbl.Deployments.OrchardCore.Vercel.ViewModels
{
    public class VercelLatestDeploymentViewModel
    {
        public InitializationState InitializationStatus { get; set; }
        public bool IsWaitingForDeployment { get; set; }
        public Deployment LatestDeployment { get; set; }
    }
}
