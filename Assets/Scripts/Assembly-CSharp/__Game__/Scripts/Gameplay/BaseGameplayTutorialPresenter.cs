using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseGameplayTutorialPresenter : SerializedMonoBehaviour
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private UIBaseGameplayTutorialView _uiGameplayTutorialView;

		[SerializeField]
		private float _startDelay;

		[SerializeField]
		private bool _showInDebugMode;

		private GameplayDebugSystem _gameplayDebugSystem;

		private Tween _startDelayTween;

		public string Guid => null;

		public event Action<string> OnTutorialCompleted
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
		private void Inject(GameplayDebugSystem gameplayDebugSystem)
		{
		}

		public abstract void Initialize();

		protected void StartTutorial()
		{
		}

		private void InvokeTutorialComplete()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
