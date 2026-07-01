using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIMergeAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertObject;

		private EquipmentMergeSystem _equipmentMergeSystem;

		[Inject]
		public void Inject(EquipmentMergeSystem equipmentMergeSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Refresh()
		{
		}
	}
}
