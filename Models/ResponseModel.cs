using System.Collections.Generic;
using AcklenAveApplication.Algorithms;

namespace AcklenAveApplication.Models
{
    public class ResponseModel
    {
        public IEnumerable<string> Words { get; set; }
        public double StartingFibonacciNumber { get; set; }
        public AlgorithmType Algorithm { get; set; }
    }

    public class EncodedResponseModel
    {
        public string Encoded { get; set; }
    }
}