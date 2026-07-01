using UnityEngine;

namespace __Game__.Scripts.Common.Components
{
	[RequireComponent(typeof(LineRenderer))]
	public class RoundedSquareLineRenderer : MonoBehaviour
	{
		[SerializeField]
		private float _squareSize;

		[SerializeField]
		private float _cornerRadius;

		[SerializeField]
		[Range(2f, 20f)]
		private int _cornerPointsCount;

		private LineRenderer _lineRenderer;

		private void Awake()
		{
		}

		private void BuildSquare()
		{
		}
	}
}
