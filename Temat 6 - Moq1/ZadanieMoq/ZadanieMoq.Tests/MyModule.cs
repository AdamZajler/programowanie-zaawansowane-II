using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieMoq.Tests
{
    public class Calculator
    {
        private IWebService _webService;

        public Calculator(IWebService webService)
        {
            _webService = webService;
        }

        public int Substract(int a, int b)
        {
            int result = a - b;
            _webService.SendData($"Substract operation: {a} - {b} = {result}");
            return result;
        }
    }
}
