using System;
using System.Collections.Generic;
using Zenject;

namespace __Game__.Scripts.Infrastructure
{
	public class GameStateMachine
	{
		private readonly Dictionary<Type, BaseGameState> _states;

		private BaseGameState _currentState;

		public GameStateMachine(DiContainer diContainer)
		{
		}

		public void Enter<TState>() where TState : BaseGameState
		{
		}

		public bool IsState<TState>() where TState : BaseGameState
		{
			return false;
		}

		public TState GetState<TState>() where TState : BaseGameState
		{
			return null;
		}

		private TState CreateState<TState>(DiContainer diContainer) where TState : BaseGameState
		{
			return null;
		}
	}
}
