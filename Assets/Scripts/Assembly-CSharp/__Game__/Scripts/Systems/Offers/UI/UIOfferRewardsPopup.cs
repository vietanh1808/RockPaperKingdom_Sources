using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems.Offers.UI
{
	public class UIOfferRewardsPopup : UIBaseOfferPopup
	{
		[Header("Rewards")]
		[SerializeField]
		private Transform _rewardsContainer;

		[SerializeField]
		private UIOfferRewardItem _rewardItemPrefab;

		private DiContainer _diContainer;

		private readonly List<UIOfferRewardItem> _spawnedItems;

		[Inject]
		private void Inject(DiContainer diContainer)
		{
		}

		protected override void OnSetup(Offer offer)
		{
		}

		private void SpawnRewardItems(List<Reward> rewards)
		{
		}

		private void ClearRewardItems()
		{
		}
	}
}
