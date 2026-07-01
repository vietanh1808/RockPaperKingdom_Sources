using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services.Analytics;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Services
{
	public class UIInterstitialChoicePopup : MonoBehaviour
	{
		[Header("Choice Buttons")]
		[SerializeField]
		private UIButtonClick _playWithAdsButton;

		[SerializeField]
		private UIButtonClick _checkOfferButton;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		private Action<bool> _onChoiceMade;

		[Inject]
		public void Construct(LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Setup(Action<bool> onChoiceMade)
		{
		}

		public void OpenPopup()
		{
		}

		private void ChoosePlayWithAds()
		{
		}

		private void ChooseOffer()
		{
		}

		private void Resolve(bool wantsOffer)
		{
		}
	}
}
