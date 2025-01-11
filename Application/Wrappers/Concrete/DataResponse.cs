using Application.Wrappers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Wrappers.Concrete
{
    public class DataResponse<T> : IDataResponse<T>
    {
        public bool Success { get; } = true;
        public T Data { get; }
        public IEnumerable<T> DataItem { get; }

        public int StatusCode { get; }
        public string Message { get; set; }

        [JsonConstructor]
        public DataResponse(IEnumerable<T> DataItems, int statuscode, string message)
        {
            DataItem = DataItems;
            StatusCode = statuscode;
            Message = message;
        }

        public DataResponse(T data, int statuscode, string message)
        {
            Data = data;
            StatusCode = statuscode;
            Message = message;
        }
    }
}
