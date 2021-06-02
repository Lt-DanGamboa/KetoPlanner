using System.Security.Principal;

namespace KetoPlanner.Entities
{
    public interface IExtendedPrincipal : IPrincipal
    {
        int Id { get; }
    }
}