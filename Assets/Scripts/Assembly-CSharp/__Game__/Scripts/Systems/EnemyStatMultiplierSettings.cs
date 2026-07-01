using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "EnemyStatMultiplierSettings", menuName = "TapHub/Stage/Enemy Stat Multiplier Settings")]
	public class EnemyStatMultiplierSettings : ScriptableObject
	{
		[SerializeField]
		private List<WaveStatMultiplier> _waveMultipliers;

		[SerializeField]
		private float _castleDamageMultiplier;

		public float CastleDamageMultiplier => 0f;

		public float GetHealthMultiplier(int waveIndex)
		{
			return 0f;
		}

		public float GetDamageMultiplier(int waveIndex)
		{
			return 0f;
		}
	}
}
