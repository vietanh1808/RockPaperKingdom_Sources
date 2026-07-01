using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[RequireComponent(typeof(AbilityObject))]
	public abstract class AbilityObjectComponent : MonoBehaviour
	{
		public abstract void ReadyToUse(AbilityObject abilityObject);
	}
}
