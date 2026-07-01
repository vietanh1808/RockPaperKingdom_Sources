using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class HeroItem : BaseCollectibleItem<HeroItemData>
	{
		private bool _isActive;

		private bool _alertSelection;

		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AlertSelection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<HeroItem> OnActiveStatusChanged
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

		public event Action OnAlertSelectionChanged
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

		public HeroItem GetCopy()
		{
			return null;
		}
	}
}
