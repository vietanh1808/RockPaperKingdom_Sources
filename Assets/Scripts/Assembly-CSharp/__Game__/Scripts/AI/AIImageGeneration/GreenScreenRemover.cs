using UnityEngine;

namespace __Game__.Scripts.AI.AIImageGeneration
{
	public static class GreenScreenRemover
	{
		private const float KEY_TOLERANCE = 0.12f;

		private const float KEY_SOFTNESS = 0.18f;

		private static readonly Color32 STATIC_GREEN;

		public static void RemoveGreenScreen(Texture2D texture)
		{
		}

		private static void KeyOutColor(Color32[] pixels, Color32 keyColor)
		{
		}

		private static Vector3 ToNormalizedRgb(Color32 color)
		{
			return default(Vector3);
		}

		private static float GreenExcess(Vector3 rgb)
		{
			return 0f;
		}
	}
}
