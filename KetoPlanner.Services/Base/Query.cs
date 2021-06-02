using System;
using System.Security.Principal;
using KetoPlanner.Entities;

namespace KetoPlanner.Services
{
    public abstract class Query<TIn, TOut>
    {
        public abstract TOut Invoke(IExtendedPrincipal user, TIn input);

        public static Query<TIn, TOut> Wrap(Func<IExtendedPrincipal, TIn, TOut> func)
        {
            return new LambdaQuery<TIn, TOut>(func);
        }
    }

    public class LambdaQuery<_TIn, _TOut> : Query<_TIn, _TOut>
    {
        private readonly Func<IExtendedPrincipal, _TIn, _TOut> Func;
        public LambdaQuery(Func<IExtendedPrincipal, _TIn, _TOut> func)
        {
            Func = func;
        }
        public override _TOut Invoke(IExtendedPrincipal user, _TIn input)
        {
            return Func(user, input);
        }
    }


}