using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseEquipmentAlert : MonoBehaviour
	{
		[SerializeField]
		private UIEquipmentElement _equipmentElement;

		[SerializeField]
		private GameObject _alertMark;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected void Refresh(bool value)
		{
		}

		protected abstract void Construct(EquipmentItem equipmentItem);

		protected abstract void Unsubscribe();
	}
}
