using System;
using System.Collections.Generic;

namespace InterfacesPolymorphism
{
    internal class VideoEncoder
    {

        private readonly IList<INotificationChannel> _notificationChannel;



        //Problem, VideoEncoder depends of MailService.
        //Tightly Coupled

        //private readonly MailService _mailService;

        //public VideoEncoder(MailService mailService)
        //{
        //    _mailService = mailService;
        //}


        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //Video encoding logic
            //...


           // _mailService.Send(new Mail());

           foreach (var channel in _notificationChannel)
           {
               channel.Send(new Message());
           }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannel.Add(channel);
        }
    }
}