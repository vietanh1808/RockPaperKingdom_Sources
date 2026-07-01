using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.StakeToken
{
	[CreateAssetMenu(fileName = "StakeTokenSettings", menuName = "TapHub/Stage/Stake Token Settings")]
	public class StakeTokenSettings : ScriptableObject
	{
		[SerializeField]
		private List<WaveStakeTokenDropModel> _waveDropModels;

		public List<WaveStakeTokenDropModel> WaveDropModels => null;

		public WaveStakeTokenDropModel GetWaveDropModel(int waveIndex)
		{
			return null;
		}
	}
}
