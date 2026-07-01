using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Common
{
	public class RandomRotationShake : MonoBehaviour
	{
		[SerializeField]
		private List<Transform> _targets;

		[SerializeField]
		private float _interval;

		[Header("Rotation")]
		[SerializeField]
		private Vector3 _minEuler;

		[SerializeField]
		private Vector3 _maxEuler;

		[Header("Position")]
		[SerializeField]
		private Vector3 _minOffset;

		[SerializeField]
		private Vector3 _maxOffset;

		private readonly List<Quaternion> _defaultRotations;

		private readonly List<Vector3> _defaultPositions;

		private float _timer;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}
	}
}
