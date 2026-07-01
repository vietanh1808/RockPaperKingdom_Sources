using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Infrastructure
{
	public class SceneController
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadScene_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string sceneName;

			public Action onLoaded;

			private AsyncOperation _003CloadOperation_003E5__2;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnFadeInComplete_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SceneController _003C_003E4__this;

			public string sceneName;

			public Action onLoaded;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private readonly UIFadeDisplay _uiFadeDisplay;

		public static string CurrentScene => null;

		public SceneController(UIProjectHolder uiProjectHolder)
		{
		}

		public void LoadInstantly(string sceneName)
		{
		}

		public void LoadFading(string sceneName, Action onLoaded = null)
		{
		}

		[AsyncStateMachine(typeof(_003COnFadeInComplete_003Ed__6))]
		private void OnFadeInComplete(string sceneName, Action onLoaded = null)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadScene_003Ed__7))]
		private Task LoadScene(string sceneName, Action onLoaded)
		{
			return null;
		}
	}
}
