using Zenject;

namespace __Game__.Scripts.Gameplay.Arena.Infrastructure
{
	public class ArenaUnitFactory : UnitFactory
	{
		private readonly UnitType _side;

		public ArenaUnitFactory(DiContainer diContainer, UIDamageView uiDamageView, UnitRepositoryFactory unitRepositoryFactory, UnitType side)
			: base(null, null, null)
		{
		}

		public override BaseUnit CreateUnit(UnitData unitData)
		{
			return null;
		}
	}
}
