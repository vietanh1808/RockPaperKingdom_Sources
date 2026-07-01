using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStageRewardElement : MonoBehaviour
	{
		[Header("Components")]
		[SerializeField]
		private UIButtonClick _claimButton;

		[SerializeField]
		private TMP_Text _requiredMessage;

		[SerializeField]
		private Image _chestIcon;

		[SerializeField]
		private RectTransform _alertMark;

		[Header("Reward Preview")]
		[SerializeField]
		private RectTransform _rewardPreviewContainer;

		[Header("Progress")]
		[SerializeField]
		private GameObject _progressIndicator;

		[Header("VFX")]
		[SerializeField]
		private GameObject _openChestVFX;

		[Header("Sprite Sets")]
		[SerializeField]
		private List<StageChestSpriteSetEntry> _spriteSets;

		private const float REWARD_ELEMENT_SIZE = 110f;

		private UIRewardsFactory _rewardsFactory;

		private bool _isPreviewVisible;

		private readonly List<GameObject> _rewardPreviewElements;

		private Dictionary<StageChestType, StageChestSpriteSet> _spriteSetMap;

		public StageChestItem ChestItem { get; private set; }

		public event Action<StageChestItem> OnButtonClicked
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

		public void Construct(StageChestItem chestItem, bool isNextChestReached)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void HandleButtonClicked()
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

		private StageChestSpriteSet GetSpriteSet(StageChestType chestType)
		{
			return null;
		}

		private void ShowAlert(bool status)
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
