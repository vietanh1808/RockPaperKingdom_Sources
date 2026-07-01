using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIFloatingRewardTarget : MonoBehaviour
	{
		[SerializeField]
		private InventoryItemData _inventoryItemData;

		[SerializeField]
		private RectTransform _targetContainer;

		private UIRewardFloating _uiRewardFloating;

		[Inject]
		private void Inject(UIRewardFloating uiRewardFloating)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
