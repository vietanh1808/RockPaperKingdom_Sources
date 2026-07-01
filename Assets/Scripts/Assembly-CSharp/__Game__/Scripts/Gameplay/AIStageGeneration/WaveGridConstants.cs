using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	public static class WaveGridConstants
	{
		public const float GRID_START_X = -4f;

		public const float GRID_END_X = 4f;

		public const float GRID_START_Z = -2f;

		public const float GRID_END_Z = -6f;

		public const float GRID_STEP = 2f;

		public const float GRID_Y = 0f;

		public const int GRID_COLUMNS = 5;

		public const int GRID_ROWS = 3;

		public const int MIN_UNITS_PER_CELL = 1;

		public const int MAX_UNITS_PER_CELL = 16;

		private const float POSITION_EPSILON = 0.01f;

		public static Vector3 GetCellPosition(int column, int row)
		{
			return default(Vector3);
		}

		public static bool IsValidGridPosition(float x, float z)
		{
			return false;
		}

		public static List<Vector3> GetAllValidPositions()
		{
			return null;
		}

		public static Vector3 GetNearestGridPosition(Vector3 worldPos)
		{
			return default(Vector3);
		}

		private static bool IsOnGridAxis(float value, float min, float max)
		{
			return false;
		}

		private static float GetNearestAxisValue(float value, float min, float max)
		{
			return 0f;
		}
	}
}
