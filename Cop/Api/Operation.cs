using System;
using System.Collections.Generic;

namespace BnEGames.Operation.Cop.Api
{
    public class Operation : IOperation
    {
        public string Id { get; set; }
        public object Payload { get; set; }
        public string Type { get; set; }
        public string Mode { get; set; }
        public string Name { get; set; }
        public object Result { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
    }
}
