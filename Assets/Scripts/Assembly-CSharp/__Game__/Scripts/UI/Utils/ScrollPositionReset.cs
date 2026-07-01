using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.UI.Utils
{
	public class ScrollPositionReset : MonoBehaviour
	{
		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private Vector2 _resetPosition;

		private void OnEnable()
		{
		}
	}
}
