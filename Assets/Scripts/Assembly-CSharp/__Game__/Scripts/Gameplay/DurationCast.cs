using System;
using DG.Tweening;

namespace __Game__.Scripts.Gameplay
{
	public class DurationCast : IAbilityCast
	{
		private Action _onCastStart;

		private Action _onCastEnd;

		private Tween _delayedCall;

		public void Cast(Ability ability, Action onCastStart, Action onCastEnd)
		{
		}

		public void Interrupt()
		{
		}
	}
}
