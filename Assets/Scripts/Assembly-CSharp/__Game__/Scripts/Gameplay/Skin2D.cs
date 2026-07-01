using DG.Tweening;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class Skin2D : MonoBehaviour
	{
		[SerializeField]
		private float _flashDuration;

		[SerializeField]
		private float _flashTargetValue;

		private static readonly int FLASH_AMOUNT;

		private static readonly int SATURATION;

		private static readonly int WHITE_AMOUNT;

		private SpriteRenderer[] _spriteRenderers;

		private MaterialPropertyBlock _propertyBlock;

		private Tween _flashTween;

		private void Awake()
		{
		}

		public void Flash()
		{
		}

		public void SetActiveState(bool isActive)
		{
		}

		public void SetFlashAmount(float value)
		{
		}
	}
}
