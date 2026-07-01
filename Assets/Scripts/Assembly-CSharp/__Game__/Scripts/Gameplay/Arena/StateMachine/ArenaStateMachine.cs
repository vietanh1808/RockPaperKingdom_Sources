using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zenject;

namespace __Game__.Scripts.Gameplay.Arena.StateMachine
{
	public class ArenaStateMachine
	{
		private readonly Dictionary<Type, BaseArenaState> _states;

		private BaseArenaState _currentState;

		public event Action<BaseArenaState> OnStateEntered
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

		public ArenaStateMachine(DiContainer diContainer)
		{
		}

		public void Enter<TState>() where TState : BaseArenaState
		{
		}

		public bool IsState<TState>() where TState : BaseArenaState
		{
			return false;
		}

		public TState GetState<TState>() where TState : BaseArenaState
		{
			return null;
		}

		private TState CreateState<TState>(DiContainer diContainer) where TState : BaseArenaState
		{
			return null;
		}
	}
}
