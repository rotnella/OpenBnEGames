using System;
using System.Collections.Generic;
using System.Text;

namespace BnEGames.Operation.Cop.Api
{
    public interface IOperationRegistry
    {
        public IOperationCompute? GetOperationCompute(Operation operation);
    }
}
