using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay
{
	public class SharedUnitRepository
	{
		private readonly Dictionary<UnitData, SharedUnit> _sharedUnitByData;

		private readonly BaseSharedUnitFactory _sharedUnitFactory;

		public SharedUnitRepository(BaseSharedUnitFactory sharedUnitFactory)
		{
		}

		public SharedUnit GetSharedUnit(UnitData unitData)
		{
			return null;
		}
	}
}
