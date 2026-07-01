namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseDebuff
	{
		private float _duration;

		public bool IsFinished => false;

		protected BaseUnit TargetUnit { get; }

		protected BaseDebuff(BaseUnit targetUnit, float duration)
		{
		}

		public virtual void Tick()
		{
		}

		public abstract void Apply();

		public abstract void Remove();

		public virtual bool CanBeApplied()
		{
			return false;
		}
	}
}
