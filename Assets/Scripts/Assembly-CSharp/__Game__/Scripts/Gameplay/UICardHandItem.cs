using DG.Tweening;
using LeTai.TrueShadow;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UICardHandItem : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rootTransform;

		[SerializeField]
		private RectTransform _cardTransform;

		[SerializeField]
		private Canvas _cardCanvas;

		[SerializeField]
		private TrueShadow _trueShadow;

		[Header("Card Info")]
		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TMP_Text _titleText;

		[SerializeField]
		private TMP_Text[] _descriptionTexts;

		[Header("Activation Settings")]
		[SerializeField]
		private float _activationScale;

		[SerializeField]
		private float _activationOffset;

		[SerializeField]
		private float _activationDuration;

		[SerializeField]
		private float _deactivationDuration;

		[Header("Shadow Settings")]
		[SerializeField]
		private Color _defaultShadowColor;

		[SerializeField]
		private Color _activeShadowColor;

		private UICardHandHolder _uiCardHandHolder;

		private Sequence _cardSequence;

		private bool _isConstructed;

		public BuildingUpgradeRuntime Upgrade { get; private set; }

		public bool IsSelected { get; private set; }

		public bool IsLocked { get; private set; }

		public RectTransform RootTransform => null;

		public RectTransform CardTransform => null;

		public void Construct(BuildingUpgradeRuntime upgrade, UICardHandHolder uiCardHandHolder)
		{
		}

		public void Uninitialize()
		{
		}

		public void Select()
		{
		}

		public void Deselect()
		{
		}

		public void Drag()
		{
		}

		public void Drop()
		{
		}

		public void Reset()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void Lock()
		{
		}

		public void Unlock()
		{
		}

		private void SetupView()
		{
		}

		private void SetupDescriptions()
		{
		}

		private void KillTween()
		{
		}
	}
}
