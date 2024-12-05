using First.Cojali.Domain.Ports;

namespace First.Cojali.Infrastructure.Adapters;

public class EmailService : IEmailService
{
    public async Task SendEmailAsync(string to, string subject, string body)
    {
        await Task.Run(() =>
        {
            Console.WriteLine($"Simulating email to: {to}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
        });
    }
}
