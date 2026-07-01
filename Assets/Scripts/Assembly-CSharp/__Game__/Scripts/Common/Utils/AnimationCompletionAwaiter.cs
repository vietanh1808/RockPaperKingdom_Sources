using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Common.Utils
{
	public class AnimationCompletionAwaiter<T> where T : class
	{
		private readonly List<T> _targets;

		private readonly Action<T, Action> _subscribe;

		private readonly Action<T, Action> _unsubscribe;

		private int _pendingCallbacksCount;

		private Action _onAllComplete;

		public AnimationCompletionAwaiter(Action<T, Action> subscribe, Action<T, Action> unsubscribe)
		{
		}

		public void WaitForAll(IReadOnlyList<T> targets, Action onAllComplete)
		{
		}

		public void Cleanup()
		{
		}

		private void OnSingleComplete()
		{
		}
	}
}
