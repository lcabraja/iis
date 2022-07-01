using System;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorService.CalculatorSoapClient client = new CalculatorService.CalculatorSoapClient(CalculatorService.CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);
            
            Console.WriteLine(client.SumAsync(1, 2).Result);
            Console.WriteLine(client.SubtractAsync(3,1).Result);

            double value = 100;
            double results = client.PriceAsync(value,4 ).Result;
            Console.WriteLine(results);


        }
    }
}
