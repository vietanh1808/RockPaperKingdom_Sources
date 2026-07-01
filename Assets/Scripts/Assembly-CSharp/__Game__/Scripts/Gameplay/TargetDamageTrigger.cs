using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class TargetDamageTrigger : MonoBehaviour
	{
		[SerializeField]
		private AbilityObject _abilityObject;

		[SerializeField]
		private TargetDamageApplier _targetDamageApplier;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
