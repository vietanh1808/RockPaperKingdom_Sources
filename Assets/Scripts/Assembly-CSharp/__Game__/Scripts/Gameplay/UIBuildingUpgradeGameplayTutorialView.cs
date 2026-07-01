using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingUpgradeGameplayTutorialView : UIBaseGameplayTutorialView
	{
		[SerializeField]
		private RectTransform _backgroundContainer;

		[SerializeField]
		private BaseBuildingData _targetBuildingData;

		[SerializeField]
		private List<BuildingSlotView> _buildingSlotViews;

		private UIUpgradesPanel _uiUpgradesPanel;

		private UICardHandHolder _uiCardHandHolder;

		private UIDragPointer _uiDragPointer;

		private UITutorialTap _uiTutorialTap;

		private RectTransform _startRectTransform;

		private Transform _endWorldTransform;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation, UIGameplayTutorialsNavigation uiGameplayTutorialsNavigation, UIProjectHolder uiProjectHolder)
		{
		}

		private void OnEnable()
		{
		}

		private void OnUpgradeSelected(UIUpgradeItem uiUpgradeItem)
		{
		}

		private void OnCardAdded()
		{
		}

		private void UpdateSlotStates()
		{
		}

		private void UpdateDragPointer()
		{
		}

		private void OnCardRemoved()
		{
		}
	}
}
