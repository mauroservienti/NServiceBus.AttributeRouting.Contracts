using System.Runtime.CompilerServices;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using PublicApiGenerator;

namespace NServiceBus.AttributeRouting.Contracts.Tests.API
{
    public class APIApprovals
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Approve_API()
        {
            var publicApi = typeof(RouteAttribute).Assembly.GeneratePublicApi(new ApiGeneratorOptions(){
                ExcludeAttributes =
                [
                    "System.Runtime.Versioning.TargetFrameworkAttribute"
                ]
            });

            Approvals.Verify(publicApi.Replace(".git", ""));
        }
    }
}