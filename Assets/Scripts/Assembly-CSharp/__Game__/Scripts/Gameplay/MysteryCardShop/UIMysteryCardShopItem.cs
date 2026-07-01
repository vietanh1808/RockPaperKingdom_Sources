using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using LeTai.TrueShadow;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.MysteryCardShop
{
	public class UIMysteryCardShopItem : MonoBehaviour
	{
		private const float FLIP_HALF_DURATION = 0.15f;

		private const float WOBBLE_DELAY = 1.5f;

		private const float WOBBLE_STEP_DURATION = 0.08f;

		private const float WOBBLE_ANGLE = 3f;

		[SerializeField]
		private RectTransform _cardTransform;

		[SerializeField]
		private GameObject _coverOverlay;

		[SerializeField]
		private UIRewardedVideoButton _rvButton;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text _nameText;

		[SerializeField]
		private TMP_Text _descriptionText;

		[SerializeField]
		private UIButtonClick _selectButton;

		[SerializeField]
		private SoundData _cardFlipSfx;

		[SerializeField]
		private TrueShadow _highlightShadow;

		private bool _isRevealed;

		private Sequence _wobbleSequence;

		public AddBuildingUpgrade Upgrade { get; private set; }

		public int Index { get; private set; }

		public bool IsRvMode { get; private set; }

		public event Action<UIMysteryCardShopItem> OnClicked
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

		public event Action<UIMysteryCardShopItem> OnRvRewardReceived
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

		public event Action<UIMysteryCardShopItem> OnRevealFinished
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

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Construct(int index)
		{
		}

		public void SetUpgrade(AddBuildingUpgrade upgrade)
		{
		}

		public void Reveal()
		{
		}

		public void SetRevealed()
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void StopWobble()
		{
		}

		public void EnableRvMode()
		{
		}

		public void DisableRvMode()
		{
		}

		public void SetLockedHighlight(bool isLocked)
		{
		}

		private void HandleSelectButtonClick()
		{
		}

		private void HandleRvCompleted(bool isSuccess)
		{
		}

		private void PlayWobbleAnimation()
		{
		}

		private void KillWobble()
		{
		}

		private void PlayRevealAnimation()
		{
		}

		private void HandleFlipHalfway()
		{
		}

		private void HandleRevealCompleted()
		{
		}
	}
}
