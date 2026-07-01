using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseShopSlot : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _title;

		[SerializeField]
		private TMP_Text _description;

		[SerializeField]
		private Image _icon;

		protected TMP_Text Title => null;

		protected TMP_Text Description => null;

		protected Image Icon => null;

		public event Action<UIBaseShopSlot> OnDeactivated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void Deactivate()
		{
		}
	}
}
