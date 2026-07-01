using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class CameraStateSettings
	{
		[SerializeField]
		private Vector3 _position;

		[SerializeField]
		private float _orthographicSize;

		public Vector3 Position => default(Vector3);

		public float OrthographicSize => 0f;

		public CameraStateSettings(Vector3 position, float orthographicSize)
		{
		}
	}
}
