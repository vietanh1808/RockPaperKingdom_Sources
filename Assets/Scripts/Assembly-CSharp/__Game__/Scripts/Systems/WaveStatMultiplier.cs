using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class WaveStatMultiplier
	{
		[SerializeField]
		private float _healthMultiplier;

		[SerializeField]
		private float _damageMultiplier;

		public float HealthMultiplier => 0f;

		public float DamageMultiplier => 0f;
	}
}
