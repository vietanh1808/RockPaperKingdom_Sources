using Zenject;
using __Game__.Scripts.Gameplay.Environment;

namespace __Game__.Scripts.Gameplay
{
	public class RandomPositionProvider : ITargetProvider
	{
		private ScreenEnvironmentBounds _screenEnvironmentBounds;

		[Inject]
		private void Inject(ScreenEnvironmentBounds screenEnvironmentBounds)
		{
		}

		public AbilityTargetLocation GetTargetPosition(Ability ability)
		{
			return null;
		}

		public bool HasTarget(Ability ability)
		{
			return false;
		}
	}
}
