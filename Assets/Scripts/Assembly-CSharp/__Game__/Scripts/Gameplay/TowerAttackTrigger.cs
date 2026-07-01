using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class TowerAttackTrigger : MonoBehaviour
	{
		[SerializeField]
		private TowerAttackObject _targetDamageApplier;

		private void OnTriggerEnter(Collider hitCollider)
		{
		}
	}
}
