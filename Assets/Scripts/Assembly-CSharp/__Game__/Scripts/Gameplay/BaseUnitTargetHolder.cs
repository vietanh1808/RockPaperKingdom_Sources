namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseUnitTargetHolder : BaseTargetHolder
	{
		protected BaseUnitTargetHolder(BaseUnit unit, UnitRepository enemyRepository)
			: base(null, null, null, null)
		{
		}
	}
}
