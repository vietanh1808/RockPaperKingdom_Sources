using System;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UITalentDrawPopup : UIBasePopup
	{
		[Header("Result Components")]
		[SerializeField]
		private RectTransform _backgroundContainer;

		[SerializeField]
		private RectTransform _descriptionContainer;

		[SerializeField]
		private RectTransform _talentContainer;

		[SerializeField]
		private UITalentUpgradeElement _uiTalentUpgradeElement;

		[SerializeField]
		private TMP_Text _descriptionText;

		[Header("Landing Animation")]
		[SerializeField]
		private float _moveDuration;

		[SerializeField]
		private float _scaleDuration;

		[SerializeField]
		private float _rotationDuration;

		[SerializeField]
		private float _minsScaleValue;

		private RarityConfig _rarityConfig;

		private Vector3 _defaultAnchorPosition;

		private Vector3 _targetAnchorPosition;

		private Action _onLandingCompleted;

		[Inject]
		private void Inject(RarityConfig rarityConfig)
		{
		}

		private void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public void Configure(TalentRuntime talentRuntime, Vector2 targetAnchorPosition, Action onLandingCompleted)
		{
		}

		protected override void ClosePopup()
		{
		}

		private void SetupView()
		{
		}

		private void OnLandingCompleted()
		{
		}
	}
}
