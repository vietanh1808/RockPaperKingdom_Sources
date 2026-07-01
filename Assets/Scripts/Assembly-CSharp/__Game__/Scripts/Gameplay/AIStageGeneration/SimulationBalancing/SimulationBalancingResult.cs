using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay.AIStageGeneration.SimulationBalancing
{
	public class SimulationBalancingResult
	{
		public List<WaveBalancingData> WaveData { get; }

		public bool AllWavesBalanced { get; set; }
	}
}
