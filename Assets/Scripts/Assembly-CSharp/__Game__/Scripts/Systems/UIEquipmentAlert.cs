using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertObject;

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

		private void RefreshEquip()
		{
		}
	}
}
