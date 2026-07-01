using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIHeroCardsTutorial : UIBaseMenuTutorial
	{
		private const float STEP_ONE_DELAY = 1f;

		private const float STEP_TWO_DELAY = 1f;

		private const float NAVIGATION_CHECK_DELAY = 0.1f;

		[Header("Navigation - Hero Page")]
		[SerializeField]
		private RectTransform _targetPage;

		[SerializeField]
		private RectTransform _targetNavigationButtonContainer;

		[Header("Navigation - Hero Popup")]
		[SerializeField]
		private UIHeroControlPopup _uiHeroControlPopup;

		[SerializeField]
		private UIHeroInventoryView _uiHeroInventoryView;

		[SerializeField]
		private RectTransform _collectibleRootContainer;

		[Header("Navigation - Cards Tab")]
		[SerializeField]
		private Toggle _cardsTab;

		[Header("Navigation - Background")]
		[SerializeField]
		private Image _imageBackground;

		[Header("Tutorial")]
		[SerializeField]
		private UIButtonClick _tapToContinueButton;

		[SerializeField]
		private GameObject _tutorialOverlay;

		[SerializeField]
		private RectTransform _heroImageContainer;

		[SerializeField]
		private RectTransform _cardsContainer;

		[Header("Tip Containers")]
		[SerializeField]
		private GameObject _firstTipContainer;

		[SerializeField]
		private GameObject _secondTipContainer;

		[SerializeField]
		private GameObject _thirdTipContainer;

		private readonly List<Canvas> _heroOverrideCanvases;

		private readonly List<GraphicRaycaster> _heroOverrideRaycasters;

		private readonly List<Canvas> _cardOverrideCanvases;

		private Tween _stepOneDelayTween;

		private Tween _stepTwoDelayTween;

		private Tween _navigationDelayTween;

		private int _currentStep;

		private UIButtonClick _uiCollectibleItemButtonClick;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void StartTutorial(Action onTutorialFinished)
		{
		}

		private void SelectHeroStep()
		{
		}

		private void OnHeroItemClicked()
		{
		}

		private void CardsTabStep()
		{
		}

		private void CardsTabStepDelayed()
		{
		}

		private void OnCardsTabActivated()
		{
		}

		private void OnTapToContinue()
		{
		}

		private void ShowCardsTutorialStepOne()
		{
		}

		private void ShowCardsTutorialStepTwo()
		{
		}

		private void ShowCardsTutorialStepThree()
		{
		}

		private void FinishTutorial()
		{
		}

		private void ApplyCardOverridesWhenReady(bool unlockedOnly)
		{
		}

		private void ApplyCardOverrides(bool unlockedOnly)
		{
		}

		private void ApplySortingOverride(Transform target, List<Canvas> canvasList, List<GraphicRaycaster> raycasterList)
		{
		}

		private void ClearCardOverrides()
		{
		}

		private void ClearAllOverrides()
		{
		}

		private void ClearOverrides(List<Canvas> canvases, List<GraphicRaycaster> raycasters)
		{
		}
	}
}
