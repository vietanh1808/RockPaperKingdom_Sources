using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class WaveLevelProgressionData
	{
		[SerializeField]
		private List<float> _waveLevelCoefficients;

		[Space]
		[SerializeField]
		private List<WaveLevelProgressionPreviewEntry> _progressionPreview;

		public int WavesCount => 0;

		public float GetCoefficient(int waveIndex)
		{
			return 0f;
		}

		public int GetTotalLevels()
		{
			return 0;
		}

		public float GetTotalCoefficientsSum()
		{
			return 0f;
		}

		public List<int> GetLevelUpsPerWave()
		{
			return null;
		}

		private void RecalculatePreview()
		{
		}
	}
}
