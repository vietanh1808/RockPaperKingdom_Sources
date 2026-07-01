using UnityEngine;

namespace __Game__.Scripts.Common
{
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class RectTransformSizeMatcher : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _source;

		[SerializeField]
		private Vector2 _padding;

		private RectTransform _rectTransform;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
