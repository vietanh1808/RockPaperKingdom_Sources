using System;
using LeTai.TrueShadow;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIUnitCardRewardElement : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _frameBackground;

		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private TMP_Text _amountText;

		[SerializeField]
		private GameObject _newMark;

		[SerializeField]
		private GameObject _burstVfx;

		[Header("Rarity")]
		[SerializeField]
		private TrueShadow _outlineShadow;

		[Header("Appear Animation")]
		[SerializeField]
		private float _appearDuration;

		[SerializeField]
		private SoundData _appearSound;

		private RarityConfig _rarityConfig;

		private UIProjectHolder _uiProjectHolder;

		private UIItemMessage _uiItemMessage;

		private UnitCardItem _rewardItem;

		private bool _isMaterialReward;

		[Inject]
		private void Inject(RarityConfig rarityConfig, UIProjectHolder uiProjectHolder, UIItemMessage uiItemMessage)
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Construct(UnitCardItem rewardItem, int amount)
		{
		}

		public void SetChestReward(ChestRewardDisplayItem displayItem)
		{
		}

		public void Appear(float delay, Action onComplete = null)
		{
		}

		public void PlayBurst()
		{
		}

		public void SetMaterialReward(Sprite icon, int amount)
		{
		}

		private void OnButtonClick()
		{
		}

		private void RefreshNewMark()
		{
		}
	}
}
