using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class UIShopSlotsLayout : MonoBehaviour
	{
		[SerializeField]
		private List<UIBaseShopSlot> _slots;

		private int _deactivatedCount;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleSlotDeactivated(UIBaseShopSlot slot)
		{
		}

		private void CheckAllDeactivated()
		{
		}
	}
}
