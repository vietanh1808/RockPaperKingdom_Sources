using UnityEngine;

namespace __Game__.Scripts.Common.Components
{
	public class DissolveViewportScaler : MonoBehaviour
	{
		[SerializeField]
		private Renderer _renderer;

		[Header("From")]
		[SerializeField]
		private Vector2Int _fromResolution;

		[SerializeField]
		private float _fromDissolveWidth;

		[SerializeField]
		private float _fromDissolveHeight;

		[Header("To")]
		[SerializeField]
		private Vector2Int _toResolution;

		[SerializeField]
		private float _toDissolveWidth;

		[SerializeField]
		private float _toDissolveHeight;

		private static readonly int SQUARE_SIZE_ID;

		private MaterialPropertyBlock _propertyBlock;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void UpdateDissolveSize()
		{
		}

		private Vector4 CalculateDissolveSize()
		{
			return default(Vector4);
		}
	}
}
