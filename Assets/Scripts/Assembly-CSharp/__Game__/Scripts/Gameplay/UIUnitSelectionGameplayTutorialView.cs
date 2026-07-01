using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIUnitSelectionGameplayTutorialView : UIBaseGameplayTutorialView
	{
		[SerializeField]
		private UnitData _targetUnitData;

		private UIUpgradesPanel _uiUpgradesPanel;

		private UITutorialTap _uiTutorialTap;

		private Action<UIUpgradeItem> _onUpgradeSelected;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation, UIProjectHolder uiProjectHolder)
		{
		}

		private void OnEnable()
		{
		}

		private void OnUpgradeSelected(UIUpgradeItem uiUpgradeItem)
		{
		}
	}
}
