using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class EquipmentTypeLevel : IComparable<EquipmentTypeLevel>
	{
		private int _level;

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

		public event Action OnLevelChanged
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

		public EquipmentTypeLevel(int level)
		{
		}

		public int CompareTo(EquipmentTypeLevel other)
		{
			return 0;
		}
	}
}
