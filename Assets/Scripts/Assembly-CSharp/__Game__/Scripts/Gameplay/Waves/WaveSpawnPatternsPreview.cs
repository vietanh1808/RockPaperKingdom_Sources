using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class WaveSpawnPatternsPreview : MonoBehaviour
	{
		[SerializeField]
		private WaveSpawnPatterns _waveSpawnPatterns;

		[SerializeField]
		private SlotGridSpawnPatternsSettings _spawnPatternsSettings;

		[Header("Wave Settings")]
		[SerializeField]
		private int _waveIndex;

		[HideInInspector]
		[SerializeField]
		private WaveSpawnPattern _waveSpawnPattern;

		[SerializeField]
		private List<int> _wavePowerValues;

		private List<int> _waveExperienceValues;

		private List<int> _accumulatedExperienceValues;

		private bool IsEditMode => false;

		private void OnWaveIndexChanged()
		{
		}

		public void ShowCurrentWave()
		{
		}

		public void ShowNextWave()
		{
		}

		public void ShowPreviousWave()
		{
		}

		private void ClearAllWaves()
		{
		}

		private void ShowWaveUnits()
		{
		}

		private void ValidateWaveIndex()
		{
		}

		public void CalculateTotalExperience()
		{
		}

		public void RecalculatePower()
		{
		}

		public void CalculateExperiencePerWave()
		{
		}
	}
}
