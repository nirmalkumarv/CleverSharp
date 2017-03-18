using System;
using CleverSharp;
using CleverSharp.Models;
using Newtonsoft.Json;

namespace GetCleverResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var clvrRequest = new CleverRequest<Schools>("DEMO_TOKEN");
            var result = clvrRequest.GetById("530e595026403103360ff9fd");
            Console.WriteLine(JsonConvert.SerializeObject(result.Data));
           
        }
    }
}