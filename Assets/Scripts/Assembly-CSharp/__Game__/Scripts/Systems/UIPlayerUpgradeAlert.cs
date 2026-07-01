using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIPlayerUpgradeAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private PlayerUpgradesSystem _playerUpgradesSystem;

		[Inject]
		public void Inject(PlayerUpgradesSystem playerUpgradesSystem)
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
