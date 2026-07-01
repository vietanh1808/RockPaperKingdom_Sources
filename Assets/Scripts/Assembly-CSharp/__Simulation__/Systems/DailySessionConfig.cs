using System;
using UnityEngine;

namespace __Simulation__.Systems
{
	[Serializable]
	public class DailySessionConfig
	{
		[SerializeField]
		private float _sessionCount;

		[SerializeField]
		private float _sessionDurationMinutes;

		public float SessionCount => 0f;

		public float SessionDurationMinutes => 0f;

		public float TotalPlaytimeMinutes => 0f;

		public int GetResolvedSessionCount(System.Random random)
		{
			return 0;
		}

		public TimeSpan GetSessionDuration(int resolvedSessionCount)
		{
			return default(TimeSpan);
		}
	}
}
