using LeTai.TrueShadow;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIUnitCardInventoryElement : UIBaseCollectibleInventoryElement<UnitCardItem, UnitCardItemData>
	{
		[Header("Containers")]
		[SerializeField]
		private GameObject _activatedContainer;

		[Header("Rarity")]
		[SerializeField]
		private TrueShadow _outlineShadow;

		[Header("Rewarded Video")]
		[SerializeField]
		private UIRewardedVideoButton _rvButton;

		private UIMenuSceneNavigation _menuSceneNavigation;

		private BaseCollectibleSystem<UnitCardItem, UnitCardItemData> _collectibleSystem;

		[Inject]
		private void Inject(UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		public override void Construct(UnitCardItem item, BaseCollectibleSystem<UnitCardItem, UnitCardItemData> baseCollectibleSystem, RarityConfig rarityConfig)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override string GetLockedInfo()
		{
			return null;
		}

		private void OnRvCompleted(bool isSuccess)
		{
		}

		private void RefreshRvButton()
		{
		}

		private void SetupOutlineColor()
		{
		}

		private void OnHeroActiveStatusChanged(HeroItem heroItem)
		{
		}

		private void RefreshActiveStatus()
		{
		}
	}
}
