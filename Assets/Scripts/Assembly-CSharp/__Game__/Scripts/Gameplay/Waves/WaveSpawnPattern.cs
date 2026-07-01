using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class WaveSpawnPattern : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		private List<WaveSpawnSlot> _waveSpawnSlots;

		public void Initialize()
		{
		}

		public void ShowPreviewUnits(SlotGridSpawnPatternsSettings spawnPatternsSettings)
		{
		}

		public void HidePreviewUnits()
		{
		}

		public List<WaveSpawnSlot> GetWaveSpawnSlots()
		{
			return null;
		}
	}
}
