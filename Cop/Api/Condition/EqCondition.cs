using System;
using System.Linq;

namespace BnEGames.Operation.Cop.Api.Condition
{
    public class EqCondition : IOperationCompute
    {

        public object Compute(Operation op)
        {
            //todo assert
            if (op == null || op.Type != typeof(EqCondition).FullName) 
                return new ConditionResult(false, null);

            Condition condition = (Condition)op.Payload;
            if (condition.Values == null || condition.Values.Count == 1)
                return new ConditionResult(false, null);

            bool solution = condition.Values.All(x => x == condition.Values.First());
            return new ConditionResult(solution, condition.Action);
        }
    }
}
