using UnityEngine;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityObject : MonoBehaviour, IPoolElement
	{
		[SerializeField]
		private string _guid;

		private AbilityObjectComponent[] _abilityObjectComponents;

		public AbilityObjectPoolContainer AbilityObjectPoolContainer { get; private set; }

		public Ability Ability { get; private set; }

		public LayerMask EnemyLayerMask { get; private set; }

		public string Guid => null;

		public void Init(AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public void SetAbility(Ability ability)
		{
		}

		private static void SetLayerRecursive(GameObject root, int layer)
		{
		}

		public void OnPoolGet()
		{
		}

		public void OnPoolRelease()
		{
		}

		public void ReadyToUse()
		{
		}

		public void Release()
		{
		}
	}
}
