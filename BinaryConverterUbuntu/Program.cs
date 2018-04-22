using System;
using System.ServiceModel;

namespace BinaryConverterUbuntu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WCF Host!");
            var binding = new BasicHttpBinding();
            var address = new Uri("http://localhost:8042/MyApp/BinaryConverterService.svc");
            var host = new ServiceHost(typeof(BinaryConverterService.BinaryConverterService));
            host.AddServiceEndpoint(typeof(BinaryConverterService.IBinaryConverterService), binding, address);
            host.Open();

            Console.WriteLine("Type [CR] to stop...");
            Console.ReadLine();
            host.Close();
        }
    }
}
