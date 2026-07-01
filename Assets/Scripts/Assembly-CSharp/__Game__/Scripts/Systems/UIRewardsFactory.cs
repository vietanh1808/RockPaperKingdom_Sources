using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIRewardsFactory
	{
		private DiContainer _diContainer;

		private UIRewardElement _rewardElement;

		private UIEquipmentRewardElement _equipmentRewardElement;

		private UIUnitCardRewardElement _unitCardRewardElement;

		private EquipmentSystem _equipmentSystem;

		private UnitCardSystem _unitCardSystem;

		[Inject]
		private void Inject(DiContainer diContainer, UIRewardElement rewardElement, UIEquipmentRewardElement equipmentRewardElement, UIUnitCardRewardElement unitCardRewardElement, EquipmentSystem equipmentSystem, UnitCardSystem unitCardSystem)
		{
		}

		public GameObject CreateElement(Reward reward, Transform parent)
		{
			return null;
		}

		public UIEquipmentRewardElement CreateEquipmentElement(EquipmentItemData itemData, RarityType rarity, int amount, Transform parent)
		{
			return null;
		}

		public UIUnitCardRewardElement CreateUnitCardElement(UnitCardItemData itemData, int amount, Transform parent)
		{
			return null;
		}

		public UIUnitCardRewardElement CreateUnitCardElement(Transform parent)
		{
			return null;
		}

		private UIRewardElement CreateRewardElement(Reward reward, Transform parent)
		{
			return null;
		}
	}
}
