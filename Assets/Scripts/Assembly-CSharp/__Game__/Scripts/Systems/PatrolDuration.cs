using System;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class PatrolDuration
	{
		public int StageIndex;

		public float Seconds;

		public float TotalHours => 0f;

		public PatrolDuration(int stageIndex, float seconds)
		{
		}

		public TimeSpan ToTimeSpan()
		{
			return default(TimeSpan);
		}
	}
}
