using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.UI
{
	public class UIDailyStreakQuestAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private DailyStreakQuestSystem _system;

		[Inject]
		public void Inject(DailyStreakQuestSystem system)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshAlert()
		{
		}
	}
}
