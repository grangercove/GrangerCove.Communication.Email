namespace GrangerCove.Communication.Email.Abstractions;

public interface IEmailSender
{
    Task<EmailSendResult> SendAsync(
        EmailMessage message,
        CancellationToken cancellationToken = default);
}