using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class CameraAspectRatioAdapter : MonoBehaviour
	{
		[Header("Aspect Ratio Settings")]
		[SerializeField]
		private Vector2Int _referenceResolution;

		[SerializeField]
		private Vector2Int _thinScreenResolution;

		[SerializeField]
		private float _thinScreenSizeMultiplier;

		[Header("Building State")]
		[SerializeField]
		private float _buildingStateThinScreenZOffset;

		[Header("Fight State")]
		[SerializeField]
		private float _fightStateThinScreenZOffset;

		private void Awake()
		{
		}

		private CameraStateSettings CreateAdjustedSettings(CameraStateSettings baseSettings, float thinScreenZOffset)
		{
			return null;
		}

		private float CalculateAspectRatioInterpolation()
		{
			return 0f;
		}
	}
}
