using UnityEngine;

namespace __Game__.Scripts.Common
{
	public class CameraAspectRatioResizer : MonoBehaviour
	{
		[SerializeField]
		private Camera _camera;

		[SerializeField]
		private float _defaultCameraSize;

		[SerializeField]
		private float _maxCameraSize;

		[SerializeField]
		private float _referenceAspectRatio;

		[SerializeField]
		private float _minAspectRatio;

		private void Start()
		{
		}

		private void ResizeCameraBasedOnAspectRatio()
		{
		}
	}
}
