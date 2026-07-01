using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class UIHeroUnlockPopup : UIHeroInfoPopup
	{
		[SerializeField]
		private List<UIUnlockedUnitCardElement> _unlockedCardElements;

		[Header("Animation")]
		[SerializeField]
		private RectTransform _titleHeroContainer;

		[SerializeField]
		private RectTransform _titleContainer;

		[SerializeField]
		private Image _titleLineImage;

		[SerializeField]
		private RectTransform _heroIconContainer;

		[SerializeField]
		private RectTransform _newCardsTitleContainer;

		[SerializeField]
		private GameObject _confettiContainer;

		[Header("Sound FX")]
		[SerializeField]
		private SoundData _heroAppearSfx;

		[SerializeField]
		private SoundData _containerMoveSfx;

		[SerializeField]
		private SoundData _cardAppearSfx;

		private const float HERO_APPEAR_DELAY = 0.2f;

		private const float HERO_APPEAR_DURATION = 0.5f;

		private const float LINE_FILL_DELAY = 0.2f;

		private const float LINE_FILL_DURATION = 0.1f;

		private const float CONTAINER_MOVE_DELAY = 1.7f;

		private const float CONTAINER_MOVE_DURATION = 0.4f;

		private const float CARD_APPEAR_DURATION = 0.3f;

		private const float CARD_STAGGER_DELAY = 0.1f;

		private static readonly Vector2 TITLE_HERO_TARGET_POSITION;

		private Sequence _appearSequence;

		private BaseCollectibleItemData _itemData;

		private Action<string> _onClosed;

		public void SetItem(BaseCollectibleItemData itemData, Action<string> onClosed)
		{
		}

		protected override void OnDisable()
		{
		}

		private List<UnitCardItemData> GetCardsToDisplay(HeroItemData heroData)
		{
			return null;
		}

		private void DisplayUnlockedCards(List<UnitCardItemData> unlockedCards)
		{
		}

		private void PlayAppearAnimation(int visibleCardsCount)
		{
		}

		private void ShowNewCardsSection(int visibleCardsCount)
		{
		}

		private void ResetAnimationState()
		{
		}
	}
}
