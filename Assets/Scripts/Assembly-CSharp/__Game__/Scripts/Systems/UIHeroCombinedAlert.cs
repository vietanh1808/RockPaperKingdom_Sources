using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIHeroCombinedAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _upgradeAlert;

		private HeroUpgradeAlertSystem _heroUpgradeAlertSystem;

		private HeroSelectionAlertSystem _heroSelectionAlertSystem;

		private HeroNewAlertSystem _heroNewAlertSystem;

		[Inject]
		private void Inject(HeroUpgradeAlertSystem heroUpgradeAlertSystem, HeroSelectionAlertSystem heroSelectionAlertSystem, HeroNewAlertSystem heroNewAlertSystem)
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
