using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class Castle : BaseBuilding
	{
		[Header("Castle")]
		[SerializeField]
		private Transform _castleTransform;

		[SerializeField]
		private CastleBuildingData _castleBuildingData;

		[Header("Castle Shake")]
		[SerializeField]
		private float _shakeDuration;

		[SerializeField]
		private float _shakeStrength;

		[Header("Damage Feedback")]
		[SerializeField]
		private SoundBundleData _damageSoundData;

		[SerializeField]
		private float _cameraShakeDuration;

		[SerializeField]
		private float _cameraShakeStrength;

		[SerializeField]
		private Canvas _damageFlashCanvas;

		[SerializeField]
		private Image _damageFlash;

		[SerializeField]
		private float _flashFadeDuration;

		private UIDamageView _uiDamageView;

		private CameraStateController _cameraStateController;

		private Tween _flashTween;

		private float _flashMaxAlpha;

		[Inject]
		public void Inject(UIDamageView uiDamageView, CameraStateController cameraStateController)
		{
		}

		public void Initialize(float hp, float armor)
		{
		}

		private void OnDamageReceived(Damage damage)
		{
		}

		private void OnCastleDeath()
		{
		}

		public void Revive(float healthPercent)
		{
		}

		public void RestoreHealth(float currentHP)
		{
		}

		public float GetCurrentHealth()
		{
			return 0f;
		}

		private void ShakeCastle()
		{
		}

		private void ShakeCamera()
		{
		}

		private void FlashDamage()
		{
		}
	}
}
