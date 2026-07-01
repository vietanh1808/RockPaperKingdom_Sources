using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "UpgradableUnitStatData", menuName = "TapHub/Stats/UpgradableUnitStatData")]
	public class UpgradableUnitStatData : ScriptableObject
	{
		[SerializeField]
		private UnitStatType _unitStatType;

		[SerializeField]
		private List<float> _multiplierByLevel;

		public UnitStatType UnitStatType => default(UnitStatType);

		public float GetStatMultiplierByLevel(int level)
		{
			return 0f;
		}
	}
}
