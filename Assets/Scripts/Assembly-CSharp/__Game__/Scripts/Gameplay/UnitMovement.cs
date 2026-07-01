using UnityEngine;
using UnityEngine.AI;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class UnitMovement
	{
		private const float MIN_DESTINATION_UPDATE_DISTANCE = 0.1f;

		private const float FLIP_DELAY = 1f;

		private Transform _rootTransform;

		private Transform _modelTransform;

		private NavMeshAgent _navMeshAgent;

		private StatValue _moveSpeed;

		private Vector3 _lastDestination;

		private float _lastFlipTime;

		private int _lastFlipDirection;

		private bool _isPaused;

		private ObstacleAvoidanceType _defaultAvoidanceType;

		private int _defaultAvoidancePriority;

		public float MoveSpeed => 0f;

		public Vector3 MoveDirection => default(Vector3);

		public float SpeedMultiplier { get; private set; }

		public bool IsMoving => false;

		public void Initialize(Transform transform, Transform modelTransform, StatValue moveSpeed, NavMeshAgent navMeshAgent)
		{
		}

		public void Disable()
		{
		}

		public void SetMoveSpeed(float moveSpeed)
		{
		}

		public void SetPaused(bool isPaused)
		{
		}

		public void MoveTowards(Vector3 targetPosition)
		{
		}

		public void FlipToTargetPosition(Vector3 targetPosition)
		{
		}

		public void SetDestinationForced(Vector3 targetPosition)
		{
		}

		public void Stop()
		{
		}

		public void SetIgnoreObstacles(bool status)
		{
		}

		public void SetSpeedMultiplier(float multiplier)
		{
		}

		private void OnMoveSpeedChanged(StatValue statValue)
		{
		}

		private void UpdateNavMeshSpeed()
		{
		}

		private void MoveToDestination(Vector3 targetPosition)
		{
		}

		private void MoveToDirection(Vector3 direction)
		{
		}

		private void UpdateFlipByDirection(Vector3 direction)
		{
		}

		private void ApplyFlip(int flipDirection)
		{
		}
	}
}
