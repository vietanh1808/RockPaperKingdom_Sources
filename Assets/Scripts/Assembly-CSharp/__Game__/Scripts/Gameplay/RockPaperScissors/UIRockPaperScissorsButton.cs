using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class UIRockPaperScissorsButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private UIButtonStateView _buttonStateView;

		[SerializeField]
		private TMP_Text _resourceAmountText;

		private RockPaperScissorsSystem _rpsSystem;

		private GameplayConfig _gameplayConfig;

		private GameplayInventorySystem _inventorySystem;

		private UIGameplaySceneNavigation _navigation;

		private InventoryItem _trackedItem;

		public UIButtonClick ButtonClick => null;

		[Inject]
		public void Inject(RockPaperScissorsSystem rpsSystem, GameplayConfig gameplayConfig, GameplayInventorySystem inventorySystem, UIGameplaySceneNavigation navigation)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Initialize()
		{
		}

		private void OnItemAmountChanged(InventoryItem item)
		{
		}

		private void UpdateResourceDisplay()
		{
		}

		private void OnButtonClicked()
		{
		}
	}
}
