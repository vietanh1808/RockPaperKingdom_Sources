using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "ItemData_Hero", menuName = "TapHub/Collectible/Hero/Hero Item Data")]
	public class HeroItemData : BaseCollectibleItemData
	{
		[Header("Unit Stats")]
		[SerializeField]
		private List<UpgradableUnitStatData> _upgradeUnitStats;

		[Header("Unit Cards")]
		[SerializeField]
		private List<UnitCardItemData> _attachedUnitCards;

		[SerializeField]
		private List<UnitCardItemData> _unlockedUnitCards;

		public List<UnitCardItemData> AttachedUnitCards => null;

		public List<UnitCardItemData> UnlockedUnitCards => null;

		public Dictionary<UnitStatType, float> GetUnitStatMultipliers(int level)
		{
			return null;
		}
	}
}
