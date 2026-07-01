using DG.Tweening;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Arena.StateMachine;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaRoundAnnouncer : MonoBehaviour
	{
		[SerializeField]
		private GameObject _rootContainer;

		[SerializeField]
		private TMP_Text _roundText;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		private const float ANIMATION_DURATION = 0.5f;

		private const float DISPLAY_DURATION = 2f;

		private ArenaWaveSystem _arenaWaveSystem;

		private ArenaStateMachine _arenaStateMachine;

		private Sequence _animationSequence;

		private Tween _hideDelayTween;

		[Inject]
		private void Inject(ArenaWaveSystem arenaWaveSystem, ArenaStateMachine arenaStateMachine)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnStateEntered(BaseArenaState state)
		{
		}

		private void ShowRoundAnnouncement()
		{
		}

		private void HideAnnouncement()
		{
		}
	}
}
