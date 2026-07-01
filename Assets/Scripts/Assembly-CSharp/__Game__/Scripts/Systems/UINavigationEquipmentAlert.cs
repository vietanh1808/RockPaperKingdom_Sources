using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UINavigationEquipmentAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private EquipmentEquipAlertSystem _equipmentEquipAlertSystem;

		private EquipmentUpgradeAlertSystem _equipmentUpgradeAlertSystem;

		private EquipmentMergeSystem _equipmentMergeSystem;

		[Inject]
		public void Inject(EquipmentEquipAlertSystem equipmentEquipAlertSystem, EquipmentUpgradeAlertSystem equipmentUpgradeAlertSystem, EquipmentMergeSystem equipmentMergeSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshNavigationInventory()
		{
		}
	}
}
