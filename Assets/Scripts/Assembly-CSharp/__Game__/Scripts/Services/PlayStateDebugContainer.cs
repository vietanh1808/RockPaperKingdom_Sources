using System.ComponentModel;
using SRDebugger;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Gameplay.StateMachine;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Services
{
	public class PlayStateDebugContainer
	{
		private readonly GameplayStateMachine _gameplayStateMachine;

		private readonly WaveSystem _waveSystem;

		private readonly Castle _castle;

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

		public PlayStateDebugContainer(GameplayStateMachine gameplayStateMachine, WaveSystem waveSystem, Castle castle, DebugService debugService)
		{
		}

		[Category("1. Lose")]
		public void Lose_0_Percent()
		{
		}

		[Category("1. Lose")]
		public void Lose_40_Percent()
		{
		}

		[Category("1. Lose")]
		public void Lose_90_Percent()
		{
		}

		[Category("2. Win")]
		public void Win_30_HP()
		{
		}

		[Category("2. Win")]
		public void Win_60_HP()
		{
		}

		[Category("2. Win")]
		public void Win_100_HP()
		{
		}

		private void Lose(float completionRate)
		{
		}

		private void Win(float castleHPPercent)
		{
		}
	}
}
