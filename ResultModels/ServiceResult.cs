using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.ServiceResult.ResultModels
{
    public class ServiceResult
    {
        [JsonIgnore]
        public bool Success { get; set; }
        public Error Error { get; set; } = new Error();

    }

    public class ServiceResult<T> : ServiceResult
    {
        public ServiceResult()
        {
        }

        public ServiceResult(ServiceResult serviceResult)
        {
            Success = serviceResult.Success;
            Error = serviceResult.Error;
        }

        public T Result { get; set; }
    }
}
