using UnityEngine;

namespace __Game__.Scripts.Common
{
	public class SpriteFlickerEffect : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer[] _sprites;

		[SerializeField]
		private float[] _alphaSteps;

		private int _spriteCount;

		private int _lastStep;

		private int _currentIndex;

		private void Awake()
		{
		}

		public void HideAll()
		{
		}

		public void ShowCurrent()
		{
		}

		public void TransitionStep(int step)
		{
		}

		public void AdvanceToNext()
		{
		}

		private static void SetAlpha(SpriteRenderer sprite, float alpha)
		{
		}
	}
}
