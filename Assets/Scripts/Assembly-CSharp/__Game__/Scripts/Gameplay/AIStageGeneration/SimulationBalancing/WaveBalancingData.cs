namespace __Game__.Scripts.Gameplay.AIStageGeneration.SimulationBalancing
{
	public class WaveBalancingData
	{
		public int WaveIndex;

		public float AvgUnitsHealthPercent;

		public int DefeatCount;

		public int StuckCount;

		public int SampleCount;

		public bool IsTooEasy;

		public bool IsTooHard;

		public bool HasCriticalDefeats => false;

		public string GetStatus()
		{
			return null;
		}
	}
}
