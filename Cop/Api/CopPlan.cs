using System;
using System.Collections.Generic;

namespace BnEGames.Operation.Cop.Api
{
    public class CopPlan
    {
        public String Title { get; set; }
        public List<Operation> Operations { get; set; }
        public Dictionary<string,Object> Parameters { get; set; }
    }
}

