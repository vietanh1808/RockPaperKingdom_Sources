using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UICardHandAspectRatioAdapter : MonoBehaviour
	{
		[Header("Aspect Ratio Settings")]
		[SerializeField]
		private Vector2Int _referenceResolution;

		[SerializeField]
		private Vector2Int _thinScreenResolution;

		[Header("Card Size Adjustment")]
		[SerializeField]
		private float _regularScreenSizeMultiplier;

		[SerializeField]
		private float _thinScreenSizeMultiplier;

		private void Awake()
		{
		}

		private float CalculateAspectRatioInterpolation()
		{
			return 0f;
		}
	}
}
