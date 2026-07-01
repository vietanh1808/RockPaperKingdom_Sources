using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UITalentInfoPopup : UIBasePopup
	{
		private const float POP_SCALE = 1.15f;

		private const float POP_DURATION = 0.15f;

		private const float SETTLE_DURATION = 0.1f;

		[SerializeField]
		private UIButtonClick _previousButtonClick;

		[SerializeField]
		private UIButtonClick _nextButtonClick;

		[SerializeField]
		private UITalentUpgradeElement _uiTalentUpgradeElement;

		[SerializeField]
		private TMP_Text _descriptionText;

		private TalentCollectionSystem _talentCollectionSystem;

		private RarityConfig _rarityConfig;

		private LinkedList<TalentRuntime> _unlockedTalents;

		private LinkedListNode<TalentRuntime> _currentNode;

		private Tween _elementPopTween;

		private Tween _descriptionPopTween;

		[Inject]
		private void Inject(TalentCollectionSystem talentCollectionSystem, RarityConfig rarityConfig)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void Configure(TalentRuntime talentRuntime)
		{
		}

		private void OnPreviousButtonClick()
		{
		}

		private void OnNextButtonClick()
		{
		}

		private void RefreshContent(TalentRuntime talentRuntime)
		{
		}

		private void SetupTalentsLinkedList()
		{
		}

		private void UpdateControls(TalentRuntime talentRuntime)
		{
		}

		private void PlayPopAnimation()
		{
		}

		private Tween CreatePopTween(Transform target)
		{
			return null;
		}
	}
}
