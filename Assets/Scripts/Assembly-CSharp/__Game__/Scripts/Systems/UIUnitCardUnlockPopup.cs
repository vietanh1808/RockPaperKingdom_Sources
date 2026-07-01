using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class UIUnitCardUnlockPopup : UIUnitCardInfoPopup
	{
		[Header("Animation")]
		[SerializeField]
		private RectTransform _titleCardContainer;

		[SerializeField]
		private RectTransform _titleContainer;

		[SerializeField]
		private Image _titleLineImage;

		[SerializeField]
		private RectTransform _cardIconContainer;

		[SerializeField]
		private RectTransform _rarityBadgeContainer;

		[SerializeField]
		private RectTransform _descriptionContainer;

		[SerializeField]
		private RectTransform _statsContainer;

		[SerializeField]
		private GameObject _confettiContainer;

		[Header("Sound FX")]
		[SerializeField]
		private SoundData _cardAppearSfx;

		[SerializeField]
		private SoundData _containerMoveSfx;

		[SerializeField]
		private SoundData _statsAppearSfx;

		private const float CARD_APPEAR_DELAY = 0.2f;

		private const float CARD_APPEAR_DURATION = 0.5f;

		private const float LINE_FILL_DELAY = 0.2f;

		private const float LINE_FILL_DURATION = 0.1f;

		private const float CONTAINER_MOVE_DELAY = 1.6f;

		private const float CONTAINER_MOVE_DURATION = 0.4f;

		private const float STATS_APPEAR_DURATION = 0.3f;

		private static readonly Vector2 TITLE_CARD_TARGET_POSITION;

		private Sequence _appearSequence;

		private BaseCollectibleItemData _itemData;

		private Action<string> _onClosed;

		public void SetItem(BaseCollectibleItemData itemData, Action<string> onClosed)
		{
		}

		protected override void OnDisable()
		{
		}

		private void PlayAppearAnimation()
		{
		}

		private void ShowDescriptionAndStats()
		{
		}

		private void ResetAnimationState()
		{
		}
	}
}
