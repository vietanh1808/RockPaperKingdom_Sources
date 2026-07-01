using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[CreateAssetMenu(fileName = "Config_OpenAI", menuName = "TapHub/AI/OpenAI Config")]
	public class OpenAIConfig : ScriptableObject
	{
		private const string GPT4_MODEL = "gpt-4";

		private const string GPT4_TURBO_MODEL = "gpt-4-turbo";

		private const string GPT4O_MODEL = "gpt-4o";

		private const string GPT4O_MINI_MODEL = "gpt-4o-mini";

		private const string GPT41_MODEL = "gpt-4.1";

		private const string GPT41_MINI_MODEL = "gpt-4.1-mini";

		private const string GPT41_NANO_MODEL = "gpt-4.1-nano";

		private const string GPT5_MODEL = "gpt-5";

		private const string GPT5_MINI_MODEL = "gpt-5-mini";

		private const string GPT5_NANO_MODEL = "gpt-5-nano";

		private const string GPT5_PRO_MODEL = "gpt-5-pro";

		private const string GPT51_MODEL = "gpt-5.1";

		private const string GPT52_MODEL = "gpt-5.2";

		private const string GPT52_PRO_MODEL = "gpt-5.2-pro";

		private const string GPT54_MODEL = "gpt-5.4";

		private const string GPT55_MODEL = "gpt-5.5";

		private const string O1_MODEL = "o1";

		private const string O1_MINI_MODEL = "o1-mini";

		private const string O3_MINI_MODEL = "o3-mini";

		[SerializeField]
		private string _apiKey;

		[SerializeField]
		private OpenAIModel _modelPreset;

		[SerializeField]
		[Range(0f, 2f)]
		private float _temperature;

		[SerializeField]
		private int _maxTokens;

		public string ApiKey => null;

		public float Temperature => 0f;

		public int MaxTokens => 0;

		public bool IsReasoningModel => false;

		public string Model => null;
	}
}
