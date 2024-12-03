using First.Cojali.Domain.Ports;

namespace First.Cojali.Infrastructure.Adapters;

public class EmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        // Simulate email sending
        Console.WriteLine($"Simulating email to: {to}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Body: {body}");
    }
}
