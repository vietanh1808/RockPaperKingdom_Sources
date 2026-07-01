using System.Threading.Tasks;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	public interface IAIChatService
	{
		Task<string> SendChatCompletionAsync(string prompt, string systemMessage);
	}
}
