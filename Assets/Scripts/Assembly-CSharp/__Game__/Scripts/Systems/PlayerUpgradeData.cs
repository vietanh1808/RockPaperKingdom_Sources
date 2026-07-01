using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class PlayerUpgradeData
	{
		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private int _requiredLevel;

		[Header("Modifier")]
		[SerializeField]
		private BaseModifier _modifier;

		[Header("Price")]
		[SerializeField]
		private PriceData _price;

		[HideInInspector]
		[SerializeField]
		private bool _isWrongOrder;

		public PriceData Price => null;

		public Sprite Icon => null;

		public BaseModifier Modifier => null;

		public int RequiredLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsWrongOrder
		{
			set
			{
			}
		}

		public void SetIcon(Sprite icon)
		{
		}
	}
}
