using BnEGames.Operation.Cop.Api;
using BnEGames.Operation.Cop.Api.Condition;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace BnEGames.Operation.Cop.Processor
{
    public class CopProcessor
    {
        public static void Run(JContainer container)
        {
            JsonRefResolver refResolver = new JsonRefResolver();
            OperationRegistry registry = new OperationRegistry();
            refResolver.Resolve(container);
            while (refResolver.HasReadyObject())
            {
                JContainer readyOp = refResolver.TakeReadyObject();
                BnEGames.Operation.Cop.Api.Operation operation = readyOp.ToObject<BnEGames.Operation.Cop.Api.Operation>();
                //perform op
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict["cxh-puid"] = "1235";
                object output = dict;
                IOperationCompute opCompute = registry.GetOperationCompute(operation);
                if (opCompute != null)
                {
                    output = opCompute.Compute(operation);
                }
                readyOp.Add(new JProperty("result", JValue.FromObject(output)));
                refResolver.ResolveFor(operation.Id);
            }
        }
    }
}
