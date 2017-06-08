namespace Centex.Services.Contact.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(Models.Contact message);
    }
}