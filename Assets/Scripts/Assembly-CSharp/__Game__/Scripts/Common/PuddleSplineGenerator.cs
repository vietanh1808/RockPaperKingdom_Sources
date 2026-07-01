using System.Collections.Generic;
using Dreamteck.Splines;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace __Game__.Scripts.Common
{
	[RequireComponent(typeof(SplineComputer))]
	public class PuddleSplineGenerator : SerializedMonoBehaviour
	{
		[SerializeField]
		private float _cellSize;

		[SerializeField]
		private float _padding;

		[SerializeField]
		[Range(0f, 5f)]
		private int _subdivisionIterations;

		[SerializeField]
		[Range(0f, 1f)]
		private float _roundness;

		[SerializeField]
		private float _wavyAmplitude;

		[SerializeField]
		private float _wavyFrequency;

		[SerializeField]
		private bool _randomizeSeedOnGenerate;

		[SerializeField]
		private int _seed;

		[SerializeField]
		[Range(0f, 1f)]
		private float _fillProbability;

		[OdinSerialize]
		private bool[,] _grid;

		private SplineComputer _splineComputer;

		private int GridRows => 0;

		private int GridCols => 0;

		private void Awake()
		{
		}

		public void Generate()
		{
		}

		public void RandomizeSeed()
		{
		}

		public void RandomizeGrid(int rows = 3, int cols = 3)
		{
		}

		private void ResizeGrid(int rows = 3, int cols = 3)
		{
		}

		private static bool DrawCell(Rect rect, bool value)
		{
			return false;
		}

		private List<Vector3> ExtractContour()
		{
			return null;
		}

		private List<(Vector2Int, Vector2Int)> CollectBoundaryEdges()
		{
			return null;
		}

		private static Vector2Int ToGridVertex(float x, float z)
		{
			return default(Vector2Int);
		}

		private static Vector3 FromGridVertex(Vector2Int v)
		{
			return default(Vector3);
		}

		private List<Vector3> OrderEdgesIntoLoop(List<(Vector2Int a, Vector2Int b)> edges)
		{
			return null;
		}

		private void CenterContour(List<Vector3> contour)
		{
		}

		private static void InsetContour(List<Vector3> contour, float distance)
		{
		}

		private static float ComputeSignedArea(List<Vector3> contour)
		{
			return 0f;
		}

		private static List<Vector3> ApplyChaikinSubdivision(List<Vector3> polygon, int iterations)
		{
			return null;
		}

		private static List<Vector3> ApplyLaplacianSmoothing(List<Vector3> polygon, float strength)
		{
			return null;
		}

		private List<Vector3> ApplyWaviness(List<Vector3> points)
		{
			return null;
		}

		private void ApplyToSpline(List<Vector3> contourPoints)
		{
		}

		private bool IsActive(int row, int col)
		{
			return false;
		}

		private void EnsureSplineComputer()
		{
		}
	}
}
