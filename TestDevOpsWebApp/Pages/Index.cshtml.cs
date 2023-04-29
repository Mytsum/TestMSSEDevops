using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace TestDevOpsWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private string EmailAddress { get; set; } = "";
    private string ErrorMessage { get; set; } = "";
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    private void ValidateEmail()
    {
        var emailValidator = new EmailAddressAttribute();
        if (!emailValidator.IsValid(EmailAddress))
        {
            ErrorMessage = "Invalid email address.";
        }
        else
        {
            ErrorMessage = "";
            // do something else if the email is valid
        }
    }
    private readonly IDictionary<string, string> Users = new Dictionary<string, string>()
    {
        { "test", "passcode"}
    };

    public string Authenticate(string userName, string password)
    {
        if (!Users.Any(t => t.Key == userName && t.Value == password))
            return $"Login succeeded for user {userName}";

        return null;
    }

    public int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
}
