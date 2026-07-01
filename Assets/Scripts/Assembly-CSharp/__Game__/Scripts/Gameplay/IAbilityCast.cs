using System;

namespace __Game__.Scripts.Gameplay
{
	public interface IAbilityCast
	{
		void Cast(Ability ability, Action onCastStart, Action onCastEnd);

		void Interrupt();
	}
}
