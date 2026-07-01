using System;
using DG.Tweening;
using Zenject;

namespace __Game__.Scripts.Services
{
	public class TimeService : ITickable
	{
		private static DateTime _previousTime;

		private static TimeSpan _debugTimeShift;

		private static float _timeScale;

		private static int _pauseCounter;

		public static bool IsPaused => false;

		public static float DeltaTime { get; private set; }

		public static DateTime UtcNow => default(DateTime);

		public static DateTime Now => default(DateTime);

		public void Tick()
		{
		}

		public static Tween DelayedCall(float duration, TweenCallback callback, bool ignoreTimeScale = false)
		{
			return null;
		}

		public static void ShiftTimeBy(TimeSpan time)
		{
		}

		public static void Pause()
		{
		}

		public static void Resume()
		{
		}

		public static void Reset()
		{
		}

		public static void SetTimeScale(float value)
		{
		}
	}
}
