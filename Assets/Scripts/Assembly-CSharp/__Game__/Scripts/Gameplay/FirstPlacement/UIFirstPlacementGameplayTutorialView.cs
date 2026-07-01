using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.FirstPlacement
{
	public class UIFirstPlacementGameplayTutorialView : UIBaseGameplayTutorialView
	{
		[SerializeField]
		private List<BuildingSlotView> _slotViews;

		private UICardHandHolder _uiCardHandHolder;

		private UIDragPointer _uiDragPointer;

		private RectTransform _startRectTransform;

		private Transform _endWorldTransform;

		[Inject]
		private void Inject(UIGameplaySceneNavigation uiGameplaySceneNavigation, UIGameplayTutorialsNavigation uiGameplayTutorialsNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateCardHand()
		{
		}

		private void ResolveTargetSlot()
		{
		}

		private void UpdateDragPointer()
		{
		}
	}
}
