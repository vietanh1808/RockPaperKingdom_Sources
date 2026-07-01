using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class CameraStateController : MonoBehaviour
	{
		[SerializeField]
		private Camera _camera;

		[SerializeField]
		private CameraStateSettings _buildingStateSettings;

		[SerializeField]
		private CameraStateSettings _fightStateSettings;

		[SerializeField]
		private float _transitionDuration;

		[SerializeField]
		private Ease _transitionEase;

		private GameplayDebugSettings _gameplayDebugSettings;

		private Sequence _transitionSequence;

		public CameraStateSettings BuildingStateSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CameraStateSettings FightStateSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<CameraStateType, float> OnStateTransition
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Inject]
		private void Inject(GameplayDebugSettings gameplayDebugSettings)
		{
		}

		private void Awake()
		{
		}

		public void SwitchToState(CameraStateType newState, Action onComplete = null)
		{
		}

		public void ApplyStateImmediate(CameraStateType stateType)
		{
		}

		private CameraStateSettings GetSettings(CameraStateType stateType)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
