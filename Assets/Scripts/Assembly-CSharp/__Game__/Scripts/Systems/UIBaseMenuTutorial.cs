using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseMenuTutorial : MonoBehaviour
	{
		[SerializeField]
		private FeatureItemData _tutorialFeatureData;

		[SerializeField]
		private UIButtonClick _skipButtonClick;

		private const float SKIP_DELAY = 30f;

		private MenuTutorialSystem _menuTutorialSystem;

		private UITutorialTap _uiTutorialTap;

		private Action _onTutorialFinished;

		private float _skipTimer;

		private bool _isSkipButtonShown;

		public FeatureItemData TutorialFeatureData => null;

		[Inject]
		private void Inject(MenuTutorialSystem menuTutorialSystem, UIProjectHolder uiProjectHolder)
		{
		}

		private void Update()
		{
		}

		public virtual void StartTutorial(Action onTutorialFinished)
		{
		}

		protected void ShowElement(Transform currentTransform, float markAngle = 0f)
		{
		}

		protected void ClearPreviousElement()
		{
		}

		protected void SaveTutorialAsCompleted()
		{
		}

		protected void CompleteTutorial()
		{
		}

		protected void ResetSkipButton()
		{
		}

		private void ShowSkipButton()
		{
		}

		private void OnSkipButtonClicked()
		{
		}
	}
}
