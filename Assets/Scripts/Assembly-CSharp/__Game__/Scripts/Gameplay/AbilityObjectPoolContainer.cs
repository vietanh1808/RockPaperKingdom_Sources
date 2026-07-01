using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityObjectPoolContainer
	{
		private readonly Dictionary<string, MonoObjectPool<AbilityObject>> _abilityObjectPools;

		private readonly DiContainer _diContainer;

		public AbilityObjectPoolContainer(DiContainer diContainer)
		{
		}

		public void CreatePool(AbilityObject abilityObjectPrefab, int initialSize = 10)
		{
		}

		private AbilityObject FactoryMethod(AbilityObject abilityObjectPrefab)
		{
			return null;
		}

		public AbilityObject GetAbilityObject(AbilityObject abilityObjectPrefab, Ability ability, Vector3 position)
		{
			return null;
		}

		public void ReturnAbilityObject(AbilityObject abilityObject)
		{
		}

		public void ReleaseAllActiveObjects()
		{
		}
	}
}
