namespace RecipeApp.API.Services;

public interface IMailService
{
    void send(string subject, string message);
}