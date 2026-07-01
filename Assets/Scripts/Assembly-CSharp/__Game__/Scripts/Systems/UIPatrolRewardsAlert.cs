using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIPatrolRewardsAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private PatrolRewardsSystem _patrolRewardsSystem;

		[Inject]
		public void Inject(PatrolRewardsSystem patrolRewardsSystem)
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
