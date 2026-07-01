namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	public class WavePowerData
	{
		public int WaveIndex { get; set; }

		public int CurrentPower { get; set; }

		public int TargetPower { get; set; }

		public int MinPower { get; set; }

		public int MaxPower { get; set; }

		public bool IsWithinTolerance => false;
	}
}
