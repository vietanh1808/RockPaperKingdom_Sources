using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Networking;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	public class ClaudeService : IAIChatService
	{
		[Serializable]
		private class ClaudeRequestBody
		{
			public string model;

			public int max_tokens;

			public string system;

			public ClaudeMessage[] messages;

			public float temperature;
		}

		[Serializable]
		private class ClaudeMessage
		{
			public string role;

			public string content;
		}

		[Serializable]
		private class ClaudeResponse
		{
			public ClaudeContentBlock[] content;
		}

		[Serializable]
		private class ClaudeContentBlock
		{
			public string type;

			public string text;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendChatCompletionAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public ClaudeService _003C_003E4__this;

			public string prompt;

			public string systemMessage;

			private UnityWebRequest _003Crequest_003E5__2;

			private UnityWebRequestAsyncOperation _003Coperation_003E5__3;

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

		private const string API_ENDPOINT = "https://api.anthropic.com/v1/messages";

		private const string ANTHROPIC_VERSION = "2023-06-01";

		private readonly ClaudeConfig _config;

		public ClaudeService(ClaudeConfig config)
		{
		}

		[AsyncStateMachine(typeof(_003CSendChatCompletionAsync_003Ed__4))]
		public Task<string> SendChatCompletionAsync(string prompt, string systemMessage)
		{
			return null;
		}

		private ClaudeRequestBody BuildRequestBody(string prompt, string systemMessage)
		{
			return null;
		}

		private string ExtractContentFromResponse(string responseJson)
		{
			return null;
		}
	}
}
