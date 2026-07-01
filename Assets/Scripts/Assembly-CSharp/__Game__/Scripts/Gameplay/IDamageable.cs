using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public interface IDamageable
	{
		IDamageable LastDamageSource { get; }

		event Action OnDied;

		void TakeDamage(Damage damage);

		Transform GetTransform();

		Vector3 GetDamagePosition(Vector3 sourcePosition);

		bool CanTakeDamage();

		bool CanBeTargeted();
	}
}
