using System;
using DG.Tweening;

namespace __Game__.Scripts.Gameplay
{
	public class MultipleReleaseCast : IAbilityCast
	{
		private Action _onCastStart;

		private Action _onCastEnd;

		private Ability _ability;

		private Tween _delayedCall;

		public void Cast(Ability ability, Action onCastStart, Action onCastEnd)
		{
		}

		public void Interrupt()
		{
		}

		private void InvokeCast(int releasesAmount, float delay)
		{
		}
	}
}
