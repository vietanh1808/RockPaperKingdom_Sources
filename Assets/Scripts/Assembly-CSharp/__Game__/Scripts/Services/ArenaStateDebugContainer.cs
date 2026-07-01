using System.ComponentModel;
using SRDebugger;
using __Game__.Scripts.Gameplay.Arena;
using __Game__.Scripts.Gameplay.Arena.StateMachine;

namespace __Game__.Scripts.Services
{
	public class ArenaStateDebugContainer
	{
		private readonly ArenaStateMachine _arenaStateMachine;

		[Category("0. Speed")]
		[NumberRange(1.0, 20.0)]
		public int GameSpeed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ArenaStateDebugContainer(ArenaStateMachine arenaStateMachine, DebugService debugService)
		{
		}

		[Category("1. Arena Result")]
		public void Win()
		{
		}

		[Category("1. Arena Result")]
		public void Lose()
		{
		}

		[Category("1. Arena Result")]
		public void Draw()
		{
		}

		private void ForceResult(ArenaMatchOutcome outcome)
		{
		}
	}
}
