using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class UIRewardChestAnimationOne : MonoBehaviour
	{
		[Header("Containers")]
		[SerializeField]
		private RectTransform _moreTransform;

		[SerializeField]
		private RectTransform _continueTransform;

		[Header("Animation")]
		[SerializeField]
		private UIRewardChestOpeningAnimation _uiRewardChestOpeningAnimation;

		private void OnDisable()
		{
		}

		public void OpenChest(ChestRewardDisplayItem displayItem)
		{
		}

		private void ResetView()
		{
		}

		private void ShowMoreDrawControls()
		{
		}

		private void ShowTapToContinue()
		{
		}
	}
}
