using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UINavigationUnitCardAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _upgradeAlert;

		private UnitCardUpgradeAlertSystem _unitCardUpgradeAlertSystem;

		[Inject]
		private void Inject(UnitCardUpgradeAlertSystem unitCardUpgradeAlertSystem)
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
