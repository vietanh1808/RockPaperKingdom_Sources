using System.Collections.Generic;
using System.Text;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	public class AIModificationPromptBuilder
	{
		public string BuildPowerFixPrompt(string currentJson, AIUnitConfig unitConfig, List<WavePowerData> powerData, int firstWavePower, int lastWavePower, int totalWaves, string stageDescription)
		{
			return null;
		}

		public string BuildCustomModificationPrompt(string currentJson, AIUnitConfig unitConfig, string userPrompt, int totalWaves, List<WavePowerData> powerData, int firstWavePower, int lastWavePower, string stageDescription)
		{
			return null;
		}

		private void AppendModificationSystemRole(StringBuilder sb)
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

		private void AppendWaveComplexityGuide(StringBuilder sb, int totalWaves)
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

		private void AppendWaveDesignProcess(StringBuilder sb)
		{
		}

		private void AppendStageDescription(StringBuilder sb, string stageDescription)
		{
		}

		private void AppendCurrentState(StringBuilder sb, string currentJson)
		{
		}

		private void AppendPowerFixInstructions(StringBuilder sb, List<WavePowerData> powerData, int firstWavePower, int lastWavePower)
		{
		}

		private void AppendPowerContext(StringBuilder sb, List<WavePowerData> powerData, int firstWavePower, int lastWavePower)
		{
		}

		private void AppendCustomInstructions(StringBuilder sb, string userPrompt)
		{
		}

		private void AppendModificationOutputFormat(StringBuilder sb, int totalWaves)
		{
		}
	}
}
