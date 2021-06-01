using System;
using System.Security.Principal;
using LanguageExt;

namespace KetoPlanner.Services
{
    public abstract class Query<TIn, TOut>
    {
        public abstract TOut Invoke(IPrincipal user, TIn input);

        public static Query<TIn, TOut> Wrap(Func<IPrincipal, TIn, TOut> func)
        {
            throw new System.NotImplementedException();
        }
    }

    public abstract class Command<TIn> : Query<TIn, Unit>
    {

    }




}