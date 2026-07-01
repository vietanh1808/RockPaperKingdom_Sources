using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseUIUpgradesReroll : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _rerollButtonClick;

		[SerializeField]
		private GameObject _adIconObject;

		[SerializeField]
		private GameObject _freeTextObject;

		[SerializeField]
		private TMP_Text _rerollsRemainingText;

		private IAdsService _adsService;

		private RerollSystem _rerollSystem;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		protected abstract string AdsPlacementName { get; }

		protected abstract string AnalyticsLocation { get; }

		[Inject]
		private void InjectBase(IAdsService adsService, RerollSystem rerollSystem, LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected abstract void PerformReroll();

		protected void UpdateButtonVisibility()
		{
		}

		protected void ShowButton()
		{
		}

		protected void HideButton()
		{
		}

		private void OnRewardedStatusChanged()
		{
		}

		private void OnRerollButtonClicked()
		{
		}

		private void OnVideoRewarded(bool isSuccessful)
		{
		}

		private void UpdateFreeAdIconState()
		{
		}

		private void UpdateRemainingText()
		{
		}
	}
}
