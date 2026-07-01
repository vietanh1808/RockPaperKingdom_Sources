using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIUnitCardCombinedAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _upgradeAlert;

		private UnitCardUpgradeAlertSystem _unitCardUpgradeAlertSystem;

		private UnitCardNewAlertSystem _unitCardNewAlertSystem;

		private HeroSystem _heroSystem;

		private UnitCardSystem _unitCardSystem;

		[Inject]
		private void Inject(UnitCardUpgradeAlertSystem unitCardUpgradeAlertSystem, UnitCardNewAlertSystem unitCardNewAlertSystem, HeroSystem heroSystem, UnitCardSystem unitCardSystem)
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

		private bool HasDeployedCardUpgrade()
		{
			return false;
		}
	}
}
