using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIDailyRewardsAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private DailyRewardsSystem _dailyRewardsSystem;

		[Inject]
		public void Inject(DailyRewardsSystem dailyRewardsSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshAlert(bool status)
		{
		}
	}
}
