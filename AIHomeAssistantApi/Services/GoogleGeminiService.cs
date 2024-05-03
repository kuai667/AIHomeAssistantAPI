using AIHomeAssistantApi.Interfaces;
using System.Text;

namespace AIHomeAssistantApi.Services;

public class GoogleGeminiService : IAIService
{
    private async Task<string> SendQuestionAsync(string question)
    {
        var client = new HttpClient();
        var content = new StringContent(GenerateContent(question),
            Encoding.UTF8,
            "application/json");

        //TODO: Add url here
        HttpResponseMessage response = await client.PostAsync("",content);

    }

    private string GenerateContent(string question)
    {
        var content = "{'contents':[{'parts':[{'text':'"+question+"'}]}]}";
        return content;
    }
}
