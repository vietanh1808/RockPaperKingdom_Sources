using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UINavigationCombinedAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _upgradeAlert;

		private HeroUpgradeAlertSystem _heroUpgradeAlertSystem;

		private HeroSelectionAlertSystem _heroSelectionAlertSystem;

		private HeroNewAlertSystem _heroNewAlertSystem;

		private UnitCardUpgradeAlertSystem _unitCardUpgradeAlertSystem;

		private UnitCardNewAlertSystem _unitCardNewAlertSystem;

		[Inject]
		private void Inject(HeroUpgradeAlertSystem heroUpgradeAlertSystem, HeroSelectionAlertSystem heroSelectionAlertSystem, HeroNewAlertSystem heroNewAlertSystem, UnitCardUpgradeAlertSystem unitCardUpgradeAlertSystem, UnitCardNewAlertSystem unitCardNewAlertSystem)
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
