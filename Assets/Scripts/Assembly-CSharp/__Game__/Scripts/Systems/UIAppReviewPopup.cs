using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIAppReviewPopup : UIBasePopup
	{
		private const float STAR_HIGHLIGHT_INTERVAL = 0.15f;

		[SerializeField]
		private List<UIStarElement> _stars;

		[SerializeField]
		private UIButtonClick _rateButton;

		private AppReviewSystem _appReviewSystem;

		private GameAnalyticsEvents _gameAnalyticsEvents;

		private Sequence _starSequence;

		private int _selectedStars;

		[Inject]
		private void Inject(AppReviewSystem appReviewSystem, GameAnalyticsEvents gameAnalyticsEvents)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void SetStarsAmount(int amount)
		{
		}

		protected override void ClosePopup()
		{
		}

		private void PlayStarRevealSequence()
		{
		}

		private void KillStarSequence()
		{
		}

		private void OnRateButtonClicked()
		{
		}
	}
}
