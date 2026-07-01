using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Gameplay.Boss;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay.UI
{
	public class UIGameplayPanel : MonoBehaviour
	{
		[SerializeField]
		private UIWaveProgress _waveProgress;

		[SerializeField]
		private GameObject _confettiOverlay;

		[SerializeField]
		private UIBossHealthPoints _bossHealthPoints;

		[SerializeField]
		private UIGameplayLevelProgression _levelProgression;

		[SerializeField]
		private Image _headerGradient;

		private CameraStateController _cameraStateController;

		private Tween _headerGradientTween;

		private Color _headerGradientInitialColor;

		public UIWaveProgress WaveProgress => null;

		public UIBossHealthPoints BossHealthPoints => null;

		[Inject]
		private void Inject(CameraStateController cameraStateController)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowConfettiOverlay()
		{
		}

		private void OnCameraStateTransition(CameraStateType stateType, float duration)
		{
		}

		private void OnBossHealthDisplayed()
		{
		}

		private void OnBossHealthHidden()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
