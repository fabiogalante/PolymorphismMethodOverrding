using System;

namespace InterfacesPolymorphism
{
    internal class VideoEncoder
    {
        //Problem, VideoEncoder depends of MailService.
        //Tightly Coupled

        private readonly MailService _mailService;

        public VideoEncoder(MailService mailService)
        {
            _mailService = mailService;
        }

        internal void Encode(Video video)
        {
            //Video encoding logic
            //...


            _mailService.Send(new Mail());
        }
    }
}