using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcklenAveApplication.Models
{
    public class ResponseModel
    {
        public IEnumerable<string> Words { get; set; }
        public double StartingFibonacciNumber { get; set; }
        public AlgorithmType AlgorithmType { get; set; }
    }

    public enum AlgorithmType
    {
        ironMan,
        captainAmerica,
        theIncredibleHulk,
        thor
    }
}