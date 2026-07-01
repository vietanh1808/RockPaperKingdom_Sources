using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Networking;

namespace __Game__.Scripts.AI.AIImageGeneration
{
	public class OpenAIImageService
	{
		public class ImageEditResult
		{
			public byte[] ImageBytes;

			public string OutputFormat;
		}

		[Serializable]
		private class ImageEditResponse
		{
			public long created;

			public ImageEditData[] data;
		}

		[Serializable]
		private class ImageEditData
		{
			public string b64_json;

			public string output_format;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendImageEditAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ImageEditResult> _003C_003Et__builder;

			public OpenAIImageService _003C_003E4__this;

			public byte[] imagePng;

			public string prompt;

			public string quality;

			public string outputFormat;

			public string size;

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

		private const string API_ENDPOINT = "https://api.openai.com/v1/images/edits";

		private const string MODEL = "gpt-image-2";

		private readonly string _apiKey;

		public OpenAIImageService(string apiKey)
		{
		}

		[AsyncStateMachine(typeof(_003CSendImageEditAsync_003Ed__4))]
		public Task<ImageEditResult> SendImageEditAsync(byte[] imagePng, string prompt, string quality = "high", string outputFormat = "png", string size = "1024x1024")
		{
			return null;
		}

		private static string BuildRequestJson(string prompt, string dataUrl, string quality, string outputFormat, string size)
		{
			return null;
		}

		private static string EscapeJson(string value)
		{
			return null;
		}

		private static ImageEditResult ParseResponse(string responseJson)
		{
			return null;
		}
	}
}
