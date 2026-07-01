using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public abstract class BaseCollectibleItem<T> where T : BaseCollectibleItemData
	{
		private T _data;

		private int _level;

		private bool _isUnlocked;

		private bool _alertUpgrade;

		private bool _isNew;

		private bool _isRewardCollected;

		public T Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public bool IsUnlocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AlertUpgrade
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsNew
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsRewardCollected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsRewardAvailable => false;

		public event Action<BaseCollectibleItem<T>> OnLevelChanged
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

		public event Action OnUnlockedChanged
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

		public event Action<bool> OnAlertUpgradeChanged
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

		public event Action<bool> OnIsNewChanged
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

		public event Action<bool> OnIsRewardCollectedChanged
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
	}
}
