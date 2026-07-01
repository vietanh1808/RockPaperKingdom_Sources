using System;
using UnityEngine;

namespace __Game__.Scripts.Common
{
	[Serializable]
	public struct TimeData
	{
		[SerializeField]
		private int _hours;

		[SerializeField]
		private int _minutes;

		[SerializeField]
		private int _seconds;

		public int Hours => 0;

		public int Minutes => 0;

		public int Seconds => 0;

		public int TotalSeconds => 0;

		public TimeData(int hours, int minutes, int seconds)
		{
			_hours = 0;
			_minutes = 0;
			_seconds = 0;
		}

		public bool HasCooldown()
		{
			return false;
		}

		public TimeSpan ToTimeSpan()
		{
			return default(TimeSpan);
		}

		public static TimeData operator -(TimeData first, TimeData second)
		{
			return default(TimeData);
		}

		private void Normalize()
		{
		}
	}
}
