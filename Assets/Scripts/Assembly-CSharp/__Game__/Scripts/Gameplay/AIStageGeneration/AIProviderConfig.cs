using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[CreateAssetMenu(fileName = "Config_AIProvider", menuName = "TapHub/AI/AI Provider Config")]
	public class AIProviderConfig : ScriptableObject
	{
		[SerializeField]
		private AIProvider _provider;

		[SerializeField]
		private OpenAIConfig _openAIConfig;

		[SerializeField]
		private ClaudeConfig _claudeConfig;

		public AIProvider Provider => default(AIProvider);

		public IAIChatService CreateService()
		{
			return null;
		}

		public bool Validate()
		{
			return false;
		}
	}
}
