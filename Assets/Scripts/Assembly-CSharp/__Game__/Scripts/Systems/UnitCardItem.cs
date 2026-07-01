using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class UnitCardItem : BaseCollectibleItem<UnitCardItemData>
	{
		private bool _isNewGameplay;

		public HeroItem HeroItem { get; set; }

		public bool IsNewGameplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<bool> OnIsNewGameplayChanged
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

		public UnitCardItem GetCopy()
		{
			return null;
		}
	}
}
