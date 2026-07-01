using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class EquipmentItem
	{
		private EquipmentTypeLevel _equipmentTypeLevel;

		private RarityType _rarity;

		private bool _isEquipped;

		private bool _isEquipAvailable;

		private bool _isUpgradeAvailable;

		private bool _isMergeAvailable;

		public EquipmentItemData Data { get; }

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public RarityType Rarity
		{
			get
			{
				return default(RarityType);
			}
			set
			{
			}
		}

		public bool IsEquipped
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsEquipAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsUpgradeAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<EquipmentItem> OnLevelChanged
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

		public event Action<bool> OnEquipStatusChanged
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

		public event Action<bool> OnUpgradeStatusChanged
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

		public EquipmentItem(EquipmentItemData data, EquipmentTypeLevel equipmentTypeLevel, RarityType rarity, bool isEquipped = false)
		{
		}

		public EquipmentItem GetCopy()
		{
			return null;
		}
	}
}
