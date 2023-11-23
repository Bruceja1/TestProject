using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CalculatorTests_xUnit
{
    public class TestDataFromFileAttribute : DataAttribute
    {
        private readonly string _filePath;

        public TestDataFromFileAttribute(string filePath)
        {
            _filePath = filePath;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {          
            var lines = File.ReadAllLines(_filePath);

            return lines.Select(line => line.Split(',').Select(int.Parse).Cast<object>().ToArray());
        }
    }
}
