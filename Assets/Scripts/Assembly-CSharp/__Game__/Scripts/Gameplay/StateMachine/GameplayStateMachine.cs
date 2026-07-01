using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zenject;

namespace __Game__.Scripts.Gameplay.StateMachine
{
	public class GameplayStateMachine
	{
		private readonly Dictionary<Type, BaseGameplayState> _states;

		private BaseGameplayState _currentState;

		public event Action<BaseGameplayState> OnStateEntered
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

		public GameplayStateMachine(DiContainer diContainer)
		{
		}

		public void Enter<TState>() where TState : BaseGameplayState
		{
		}

		private TState CreateState<TState>(DiContainer diContainer) where TState : BaseGameplayState
		{
			return null;
		}

		public bool IsState<TState>() where TState : BaseGameplayState
		{
			return false;
		}

		public TState GetState<TState>() where TState : BaseGameplayState
		{
			return null;
		}
	}
}
