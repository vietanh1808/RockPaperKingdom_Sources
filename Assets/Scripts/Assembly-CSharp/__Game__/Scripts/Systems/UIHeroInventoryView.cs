using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIHeroInventoryView : UIBaseCollectibleInventoryView<HeroSystem, HeroItem, HeroItemData>
	{
		[SerializeField]
		private UIButtonClick _cancelSelectionButton;

		private HeroSystem _heroSystem;

		private UIMenuSceneNavigation _menuSceneNavigation;

		[Inject]
		private void Inject(HeroSystem heroSystem, UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		protected new void OnEnable()
		{
		}

		protected new void OnDisable()
		{
		}

		protected override void ElementButtonClicked(HeroItem collectibleItem)
		{
		}

		private void ShowAllElements()
		{
		}

		private void ShowSelectedElement()
		{
		}

		private void ShowAllCandidates()
		{
		}

		private void OnCancelButtonClicked()
		{
		}
	}
}
