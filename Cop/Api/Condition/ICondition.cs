using System.Collections.Generic;

namespace BnEGames.Operation.Cop.Api.Condition
{
    public interface ICondition
    {
        string Operand { get; set; }
        IConditionResult Result { get; set; }
        List<object> Values { get; set; }
        public object Action { get; set; }
    }
}