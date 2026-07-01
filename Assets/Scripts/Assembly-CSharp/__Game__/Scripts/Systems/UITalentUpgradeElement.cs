using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using LeTai.TrueShadow;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UITalentUpgradeElement : MonoBehaviour
	{
		[Header("Components")]
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private RectTransform _rootTransform;

		[SerializeField]
		private RectTransform _lockedContainer;

		[SerializeField]
		private RectTransform _unlockedContainer;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TrueShadow _rarityShadow;

		[SerializeField]
		private TMP_Text _levelText;

		private RarityConfig _rarityConfig;

		private TalentRuntime _talentRuntime;

		private Tween _popupTween;

		public RectTransform RootTransform => null;

		public event Action<TalentRuntime> OnTalentButtonClicked
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Construct(TalentRuntime talentRuntime, RarityConfig rarityConfig)
		{
		}

		public void Refresh(TalentRuntime talentRuntime)
		{
		}

		public void PlayPopAnimation()
		{
		}

		private void UpdateStatus(bool isUnlocked)
		{
		}

		private void UpdateLevel(int levelIndex)
		{
		}

		private void SetupRarityVisual(RarityType rarityType)
		{
		}

		private void OnButtonClicked()
		{
		}
	}
}
