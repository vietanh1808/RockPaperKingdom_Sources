using System.Text;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	public class AIPromptBuilder
	{
		private const string EXAMPLE_JSON = "{\n    \"waves\": [\n        {\n            \"waveIndex\": 0,\n            \"cells\": [\n                {\"x\": 0, \"z\": -4, \"unitGuid\": \"WARRIOR_GUID\", \"amount\": 6}\n            ]\n        },\n        {\n            \"waveIndex\": 1,\n            \"cells\": [\n                {\"x\": -2, \"z\": -4, \"unitGuid\": \"WARRIOR_GUID\", \"amount\": 5},\n                {\"x\": 2, \"z\": -4, \"unitGuid\": \"WARRIOR_GUID\", \"amount\": 5}\n            ]\n        },\n        {\n            \"waveIndex\": 2,\n            \"cells\": [\n                {\"x\": 0, \"z\": -4, \"unitGuid\": \"WARRIOR_GUID\", \"amount\": 8},\n                {\"x\": 0, \"z\": -2, \"unitGuid\": \"TANK_GUID\", \"amount\": 3}\n            ]\n        }\n    ]\n}";

		public string BuildPrompt(int totalWaves, string stageDescription, AIUnitConfig unitConfig, int firstWavePower, int lastWavePower)
		{
			return null;
		}

		private void AppendSystemRole(StringBuilder sb)
		{
		}

		private void AppendGridSpecification(StringBuilder sb, int totalWaves)
		{
		}

		private void AppendPowerRequirements(StringBuilder sb, int totalWaves, int firstWavePower, int lastWavePower)
		{
		}

		private void AppendUnitCatalog(StringBuilder sb, AIUnitConfig unitConfig)
		{
		}

		private void AppendUnitInfo(StringBuilder sb, UnitData unit, string category)
		{
		}

		private void AppendUnitQuickReference(StringBuilder sb, AIUnitConfig unitConfig)
		{
		}

		private void AppendPlacementRules(StringBuilder sb, int totalWaves)
		{
		}

		private void AppendHardConstraints(StringBuilder sb, int totalWaves)
		{
		}

		private void AppendBossRestriction(StringBuilder sb, int totalWaves)
		{
		}

		private void AppendSymmetryRequirements(StringBuilder sb)
		{
		}

		private void AppendWaveComplexityGuide(StringBuilder sb, int totalWaves)
		{
		}

		private void AppendWaveDesignProcess(StringBuilder sb)
		{
		}

		private void AppendStageDescription(StringBuilder sb, string stageDescription)
		{
		}

		private void AppendExampleJson(StringBuilder sb, AIUnitConfig unitConfig)
		{
		}

		private void AppendOutputFormat(StringBuilder sb, int totalWaves)
		{
		}
	}
}
