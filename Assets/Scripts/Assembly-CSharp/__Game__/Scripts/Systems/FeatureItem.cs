using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class FeatureItem
	{
		private bool _isUnlocked;

		public FeatureItemData Data { get; }

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

		public event Action<FeatureItem> OnFeatureItemStatusChanged
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

		public FeatureItem(FeatureItemData data, bool isUnlocked)
		{
		}
	}
}
