using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIRewardChest : UIBasePopup
	{
		[Header("Buttons")]
		[SerializeField]
		private UIPurchaseButton _secondaryPurchaseButton;

		[Header("Views")]
		[SerializeField]
		private Image _closedImage;

		[SerializeField]
		private Image _openImage;

		[Header("Animation")]
		[SerializeField]
		private UIRewardChestAnimationOne _uiRewardChestAnimationOne;

		[SerializeField]
		private UIRewardChestAnimationMultiple _uiRewardChestAnimationMultiple;

		private ChestSystem _chestSystem;

		private UnitCardSystem _unitCardSystem;

		private InventorySystem _inventorySystem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		private readonly List<UnitCardItemData> _pendingNewCardUnlocks;

		[Inject]
		public void Inject(ChestSystem chestSystem, UnitCardSystem unitCardSystem, InventorySystem inventorySystem, UIMenuSceneNavigation uiMenuSceneNavigation)
		{
		}

		public void SetChest(ChestData chestData)
		{
		}

		public void OpenChest(ChestDataAmount chestDataAmount)
		{
		}

		protected override void ClosePopup()
		{
		}

		private void OpenOneChest(ChestDataAmount chestDataAmount)
		{
		}

		private void OpenOneMultiple(ChestDataAmount chestDataAmount)
		{
		}

		private ChestRewardDisplayItem BuildDisplayItem(ChestRewardItem rewardItem)
		{
			return null;
		}

		private void EnqueueNextPendingNewCardUnlock()
		{
		}

		private void OnUnitCardUnlockClosed(string guid)
		{
		}

		private void RefreshPurchaseButtons()
		{
		}
	}
}
