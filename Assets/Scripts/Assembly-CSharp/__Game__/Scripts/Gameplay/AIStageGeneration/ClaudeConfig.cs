using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[CreateAssetMenu(fileName = "Config_Claude", menuName = "TapHub/AI/Claude Config")]
	public class ClaudeConfig : ScriptableObject
	{
		private const string CLAUDE_35_SONNET_MODEL = "claude-3-5-sonnet-latest";

		private const string CLAUDE_37_SONNET_MODEL = "claude-3-7-sonnet-latest";

		private const string CLAUDE_4_OPUS_MODEL = "claude-opus-4-0";

		private const string CLAUDE_4_SONNET_MODEL = "claude-sonnet-4-6";

		private const string CLAUDE_46_OPUS_MODEL = "claude-opus-4-6";

		[SerializeField]
		private string _apiKey;

		[SerializeField]
		private ClaudeModel _modelPreset;

		[SerializeField]
		[Range(0f, 1f)]
		private float _temperature;

		[SerializeField]
		private int _maxTokens;

		public string ApiKey => null;

		public float Temperature => 0f;

		public int MaxTokens => 0;

		public string Model => null;
	}
}
