using Newtonsoft.Json;
using System.Collections.Generic;

namespace BnEGames.Operation.Cop.Api.Condition
{
    public class Condition : ICondition
    {
        protected Condition(string operand, List<object> values, object action)
        {
            Operand = operand;
            Values = values;
            Action = action;
        }

        public string Operand { get; set; }
        public List<object> Values { get; set; }
        public object Action { get; set; }
        public IConditionResult Result { get; set; }

        public static Condition? FromJson(string json)
        {
            if (json == null) return null;
            return JsonConvert.DeserializeObject<Condition>(json);
        }
    }
}
