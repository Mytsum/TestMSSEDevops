﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace TestDevOpsWebApp.Pages;

public class IndexModel : PageModel
{
    private IConfiguration configuration;
    private string EmailAddress { get; set; } = "";
    private string ErrorMessage { get; set; } = "";
    public string indexUI { get; private set; } = "";
    public string env_index { get; private set; } = "";
    public IndexModel(IConfiguration _configuration)
    {
        configuration = _configuration;
    }

    public void OnGet()
    {
        indexUI = configuration["Index:Header"].ToString();
        env_index = Environment.GetEnvironmentVariable("ENV_INDEX");
        CallStg();
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
    private void CallTest()
    {
        if (env_index == "Test")
        {
            indexUI = "Test";
        }
    }
    private void CallDev()
    {
        if (env_index == "Development")
        {
            indexUI = "Development";
        }
    }
    private void CallStg()
    {
        if (env_index == "Staging")
        {
            indexUI = "Staging";
        }
    }
    private void CallPrd()
    {
        if (env_index == "Production")
        {
            indexUI = "Production";
        }
    }
}
