using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class UIRPSSessionRewardsController : MonoBehaviour
	{
		[SerializeField]
		private List<UIRPSSessionRewardElement> _sessionRewardElements;

		private UIItemMessage _uiItemMessage;

		[Inject]
		public void Inject(UIItemMessage uiItemMessage)
		{
		}

		public void Setup(IReadOnlyList<RPSOutcomeData> outcomes)
		{
		}

		private bool IsDisplayableOutcome(RPSOutcomeType outcomeType)
		{
			return false;
		}

		public void UpdateReward(RPSOutcomeData outcome)
		{
		}

		public UIRPSSessionRewardElement GetTargetElement(RPSOutcomeData outcome)
		{
			return null;
		}

		public void ResetSession()
		{
		}

		public bool HasAnyRewards()
		{
			return false;
		}
	}
}
