using System;
using System.Collections.Generic;
using System.Text;

namespace SS.ServiceResult.ResultModels
{
    public class Error
    {
        public int StatusCode { get; set; }
        public string Description { get; set; }
    }
}
