using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIGridExpandButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _button;

		[SerializeField]
		private TMP_Text _amountText;

		private GridExpandSystem _gridExpandSystem;

		private GameplayInventorySystem _gameplayInventorySystem;

		private InventoryItem _expandItem;

		[Inject]
		public void Inject(GridExpandSystem gridExpandSystem, GameplayInventorySystem gameplayInventorySystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnButtonClick()
		{
		}

		private void OnExpandItemAmountChanged(InventoryItem item)
		{
		}

		private void SubscribeToExpandItem()
		{
		}

		private void UnsubscribeFromExpandItem()
		{
		}

		private void UpdateAmountText()
		{
		}
	}
}
