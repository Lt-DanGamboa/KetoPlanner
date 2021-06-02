using System.Security.Principal;
using KetoPlanner.Entities;

namespace KetoPlanner.Tests.Mocks
{
    public class MockPrincipal : IExtendedPrincipal
    {
        private class MockIdentity : IIdentity
        {
            public string Name { get; }
            public bool IsAuthenticated { get; }
            public string AuthenticationType { get; }
        }
        public IIdentity Identity => new MockIdentity();
        public int Id { get; }
        public bool IsInRole(string role)
        {
            return false;
        }
    }
}