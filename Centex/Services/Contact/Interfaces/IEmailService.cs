namespace Centex.Services.Contact.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(Models.Contact message, string address, string name);
    }
}