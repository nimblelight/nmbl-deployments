using Nmbl.Deployments.Core.Models;
using Nmbl.Deployments.Vercel.Models;

namespace Nmbl.Deployments.Vercel.OcModule.ViewModels
{
    public class VercelLatestDeploymentViewModel
    {
        public InitializationState InitializationStatus { get; set; }
        public bool IsWaitingForDeployment { get; set; }
        public VercelDeployment LatestDeployment { get; set; }
    }
}