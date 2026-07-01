using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UnitFactory
	{
		protected readonly DiContainer _diContainer;

		protected readonly UIDamageView _uiDamageView;

		protected readonly UnitRepositoryFactory _unitRepositoryFactory;

		public UnitFactory(DiContainer diContainer, UIDamageView uiDamageView, UnitRepositoryFactory unitRepositoryFactory)
		{
		}

		public virtual BaseUnit CreateUnit(UnitData unitData)
		{
			return null;
		}
	}
}
