using System;

namespace InterfacesPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder(new MailService());
            encoder.Encode(new Video());
        }
    }
}
