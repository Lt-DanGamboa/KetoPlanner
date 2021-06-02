using System;
using System.Security.Principal;
using KetoPlanner.Entities;
using LanguageExt;

namespace KetoPlanner.Services
{
    public abstract class Command<TIn> : Query<TIn, Unit>
    {
        public static Command<TIn> Wrap(Action<IExtendedPrincipal, TIn> action)
        {
            return new LambdaCommand<TIn>(action);
        }
    }

    public class LambdaCommand<TIn> : Command<TIn>
    {
        public LambdaCommand(Action<IExtendedPrincipal, TIn> action)
        {
            Action = action;
        }
        public override Unit Invoke(IExtendedPrincipal user, TIn input)
        {
            Action(user, input);
            return Unit.Default;
        }

        private readonly Action<IExtendedPrincipal, TIn> Action;
    }


}