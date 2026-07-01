using System;
using DG.Tweening;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay.BossChest
{
	public class BossChestObject : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		[SerializeField]
		private SpriteRenderer _shadow;

		[Header("Consume Animation")]
		[SerializeField]
		private float _scaleDuration;

		[SerializeField]
		private float _targetScale;

		[SerializeField]
		private Ease _scaleEase;

		[Header("Shake Animation")]
		[SerializeField]
		private float _shakeAngle;

		[SerializeField]
		private float _shakeDuration;

		[SerializeField]
		private int _shakeLoops;

		[SerializeField]
		private Ease _shakeEase;

		[SerializeField]
		private SoundData _shakeSound;

		[Header("Sorting")]
		[SerializeField]
		private int _consumeSortingOrder;

		private Camera _mainCamera;

		public void Initialize()
		{
		}

		public Vector2 GetViewportPosition()
		{
			return default(Vector2);
		}

		public void PlayConsumeAnimation(Action onComplete)
		{
		}
	}
}
