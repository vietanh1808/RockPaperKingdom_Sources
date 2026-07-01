using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UITalentCollectionAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private TalentCanDrawTracker _talentCanDrawTracker;

		[Inject]
		public void Inject(TalentCanDrawTracker talentCanDrawTracker)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCanDrawStatusChanged()
		{
		}
	}
}
