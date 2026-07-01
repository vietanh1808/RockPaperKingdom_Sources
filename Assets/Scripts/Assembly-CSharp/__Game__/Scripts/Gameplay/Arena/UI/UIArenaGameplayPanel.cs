using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Gameplay.Arena.Enemy;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaGameplayPanel : MonoBehaviour
	{
		[SerializeField]
		private UIArenaWaveText _arenaWaveText;

		[SerializeField]
		private UIArenaRoundAnnouncer _arenaRoundAnnouncer;

		[SerializeField]
		private Image _headerGradient;

		[SerializeField]
		private GameObject _confettiOverlay;

		[Header("Castle Health")]
		[SerializeField]
		private UIArenaCastleHealthBar _playerCastleHealthBar;

		[SerializeField]
		private UIArenaCastleHealthBar _enemyCastleHealthBar;

		private CameraStateController _cameraStateController;

		private Castle _castle;

		private ArenaEnemySetup _arenaEnemySetup;

		private Tween _headerGradientTween;

		private Color _headerGradientInitialColor;

		[Inject]
		private void Inject(CameraStateController cameraStateController, Castle castle, ArenaEnemySetup arenaEnemySetup)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCameraStateTransition(CameraStateType stateType, float duration)
		{
		}

		public void ShowConfettiOverlay()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
