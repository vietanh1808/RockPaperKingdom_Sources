using System;
using System.Runtime.CompilerServices;
using DG.Tweening;

namespace __Game__.Scripts.Loading
{
	public class LoadingProgressController : IDisposable
	{
		private const float LOADING_DURATION = 0f;

		private Tween _progressTween;

		private float _currentProgress;

		public float Duration => 0f;

		public bool IsInProgress { get; private set; }

		public event Action<float> OnProgressChanged
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

		public event Action OnProgressCompleted
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

		public void StartProgress()
		{
		}

		public void StopProgress()
		{
		}

		public void Dispose()
		{
		}
	}
}
