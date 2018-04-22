using System;
using System.ServiceModel;

namespace BinaryConverterClient
{
    public class BinaryConverterRequest
    {
        public BinaryConverterRequest()
        {
        }

        public string RequestToBinaryConverter(string addr, int n)
        {
            string response = "";

            ChannelFactory<BinaryConverterService.IBinaryConverterService> factory = null;
            try
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                //http://192.168.1.106/MyApp/BinaryConverterService.svc
                EndpointAddress address = new EndpointAddress("http://localhost:8042/MyApp/BinaryConverterService.svc");
                factory = new ChannelFactory<BinaryConverterService.IBinaryConverterService>(binding, address);
                BinaryConverterService.IBinaryConverterService channel = factory.CreateChannel();
                response = channel.GetBinary(n);
                factory.Close();
            }
            catch (Exception ex)
            {
                if (factory != null)
                {
                    factory.Abort();
                }
                response = ex.ToString();
            }
            return response;
        }
    }
}
