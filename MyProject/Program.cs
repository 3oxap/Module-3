using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddCommandLine(args, new Dictionary<string, string>
            {
                ["-Name"]="Name"    
            });
            var config = builder.Build();
            var line= DateLibrary.Class1.Output(config["Name"]);
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
