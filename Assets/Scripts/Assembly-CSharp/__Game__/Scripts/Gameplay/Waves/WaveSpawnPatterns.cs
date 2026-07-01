using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class WaveSpawnPatterns : MonoBehaviour
	{
		[SerializeField]
		private List<WaveSpawnPattern> _waveSpawnPatterns;

		public void Initialize()
		{
		}

		public int GetWavesAmount()
		{
			return 0;
		}

		public List<WaveSpawnPattern> GetAllWaveSpawnPatterns()
		{
			return null;
		}

		public WaveSpawnPattern GetWaveSpawnPattern(int index)
		{
			return null;
		}

		public List<WaveSpawnSlot> GetWaveSpawnSlots(int index)
		{
			return null;
		}

		private void SetupWaveSpawnPatterns()
		{
		}

		private void ValidateDuplicateSlots()
		{
		}
	}
}
