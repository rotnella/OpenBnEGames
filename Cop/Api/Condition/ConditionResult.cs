using System;

namespace BnEGames.Operation.Cop.Api.Condition
{
    public class ConditionResult : IConditionResult
    {
        public ConditionResult(object solution, object action)
        {
            Solution = solution;
            Action = action;
        }

        public object Solution { get; set; }
        public object Action { get; set; }
    }
}
