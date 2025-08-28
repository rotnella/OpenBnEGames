using BnEGames.Operation.Cop.Api.Condition;
using System;
using System.Collections.Generic;
using System.Text;

namespace BnEGames.Operation.Cop.Api
{
    public class OperationRegistry : IOperationRegistry
    {
        Dictionary<string, IOperationCompute> registeredOperations = new Dictionary<string, IOperationCompute>()
        {
            [typeof(EqCondition).FullName] = new EqCondition()
        };

        public IOperationCompute? GetOperationCompute(Operation operation)
        {
            if (registeredOperations.ContainsKey(operation.Type))
            {
                return registeredOperations[operation.Type];
            }
            return null;
        }

        public void RegisterOperationCompute(string key, IOperationCompute opCompute)
        {
            registeredOperations.Add(key, opCompute);
        }
    }
}
