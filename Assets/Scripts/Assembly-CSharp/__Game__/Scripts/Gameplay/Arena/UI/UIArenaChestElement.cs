using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaChestElement : MonoBehaviour
	{
		private const float REWARD_ELEMENT_SIZE = 110f;

		[Header("Components")]
		[SerializeField]
		private UIButtonClick _chestButton;

		[SerializeField]
		private Image _chestIcon;

		[SerializeField]
		private GameObject _alertMark;

		[SerializeField]
		private TMP_Text _requiredRatingText;

		[Header("Reward Preview")]
		[SerializeField]
		private RectTransform _rewardPreviewContainer;

		[Header("VFX")]
		[SerializeField]
		private GameObject _claimVFX;

		[Header("Sprites")]
		[SerializeField]
		private Sprite _lockedIcon;

		[SerializeField]
		private Sprite _unlockedIcon;

		[SerializeField]
		private Sprite _claimedIcon;

		private ArenaChestItem _chestItem;

		private UIRewardsFactory _rewardsFactory;

		private bool _isPreviewVisible;

		private readonly List<GameObject> _rewardPreviewElements;

		public event Action<ArenaChestItem> OnClaimClicked
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

		[Inject]
		private void Inject(UIRewardsFactory rewardsFactory)
		{
		}

		public void Construct(ArenaChestItem chestItem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void HandleChestClicked()
		{
		}

		private void ToggleRewardPreview()
		{
		}

		private void ShowRewardPreview()
		{
		}

		private void HideRewardPreview()
		{
		}

		private void ClearRewardPreviewElements()
		{
		}

		private void Subscribe()
		{
		}

		private void Unsubscribe()
		{
		}

		private void RefreshView()
		{
		}

		private void ShowLoopAnimation()
		{
		}

		private void StopLoopAnimation()
		{
		}
	}
}
