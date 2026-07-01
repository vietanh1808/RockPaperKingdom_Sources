using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_Hero", menuName = "TapHub/Collectible/Hero/Hero Config")]
	public class HeroConfig : BaseCollectibleConfig<HeroItemData>
	{
		[SerializeField]
		private List<HeroItemData> _defaultSelected;

		[SerializeField]
		private int _maxSelectableHeroes;

		[SerializeField]
		private bool _autoSelect;

		[SerializeField]
		private HeroItemData _heroSelectionTriggerHero;

		[Header("Unlock Reward")]
		[SerializeField]
		private Reward _unlockReward;

		public List<HeroItemData> DefaultSelected => null;

		public int MaxSelectableHeroes => 0;

		public bool AutoSelect => false;

		public HeroItemData HeroSelectionTriggerHero => null;

		public Reward UnlockReward => null;
	}
}
