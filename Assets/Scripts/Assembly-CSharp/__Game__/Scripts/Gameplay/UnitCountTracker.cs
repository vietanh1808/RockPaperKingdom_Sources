using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Gameplay
{
	public class UnitCountTracker
	{
		private readonly UnitRepository _unitRepository;

		public int UnitsLeft { get; private set; }

		public event Action<int> OnUnitCountChanged
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

		public UnitCountTracker(UnitRepository unitRepository)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnUnitAdded(BaseUnit unit)
		{
		}

		private void OnUnitRemoved(BaseUnit unit)
		{
		}
	}
}
