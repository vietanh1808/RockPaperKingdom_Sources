using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	public class AIJsonValidator
	{
		private static readonly HashSet<int> VALID_X_POSITIONS;

		private static readonly HashSet<int> VALID_Z_POSITIONS;

		private static readonly HashSet<int> MINI_BOSS_WAVE_INDICES;

		private static readonly HashSet<int> BOSS_WAVE_INDICES;

		public bool Validate(AIStageResponse response, AIUnitConfig unitConfig, int expectedWaves)
		{
			return false;
		}

		public bool ValidateExtended(AIStageResponse response, AIUnitConfig unitConfig, int expectedWaves, int firstWavePower, int lastWavePower)
		{
			return false;
		}

		private bool ValidateWaveCount(AIStageResponse response, int expectedWaves)
		{
			return false;
		}

		private bool ValidateWaveIndices(AIStageResponse response)
		{
			return false;
		}

		private bool ValidateEmptyWaves(AIStageResponse response)
		{
			return false;
		}

		private bool ValidateDuplicateCells(AIStageResponse response)
		{
			return false;
		}

		private bool ValidateCells(AIStageResponse response, AIUnitConfig unitConfig)
		{
			return false;
		}

		private bool ValidatePosition(AIGridCellData cell, int waveIndex)
		{
			return false;
		}

		private bool ValidateUnitGuid(AIGridCellData cell, AIUnitConfig unitConfig, int waveIndex)
		{
			return false;
		}

		private bool ValidateAmount(AIGridCellData cell, int waveIndex)
		{
			return false;
		}

		private bool ValidateSpecialWaves(AIStageResponse response, AIUnitConfig unitConfig, int expectedWaves)
		{
			return false;
		}

		private bool ValidateBossPlacement(AIStageResponse response, AIUnitConfig unitConfig, int expectedWaves)
		{
			return false;
		}

		private bool ValidateMiniBossWave(AIStageResponse response, AIUnitConfig unitConfig, int waveIndex)
		{
			return false;
		}

		private bool ValidateBossWave(AIStageResponse response, AIUnitConfig unitConfig, int waveIndex)
		{
			return false;
		}

		private void ValidateSymmetry(AIStageResponse response)
		{
		}

		private void ValidatePower(AIStageResponse response, AIUnitConfig unitConfig, int totalWaves, int firstWavePower, int lastWavePower)
		{
		}
	}
}
