using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay.BossChest.UI
{
	public class UIBossChestUpgradeItem : MonoBehaviour
	{
		[Header("Icon Container")]
		[SerializeField]
		private UIIconRoller _iconRoller;

		[SerializeField]
		private Image _iconContainerImage;

		[SerializeField]
		private Image _finalIcon;

		[SerializeField]
		private GameObject _backgroundGlow;

		[Header("Card Container")]
		[SerializeField]
		private CanvasGroup _cardContainer;

		[SerializeField]
		private TMP_Text _title;

		[SerializeField]
		private TMP_Text[] _descriptionTexts;

		[SerializeField]
		private TMP_Text _hintText;

		[Header("Interaction")]
		[SerializeField]
		private Button _button;

		[Header("Animation Settings")]
		[SerializeField]
		private float _appearDuration;

		[SerializeField]
		private float _cardRevealDuration;

		[SerializeField]
		private float _cardRevealStartScale;

		[SerializeField]
		private float _iconPopDuration;

		[SerializeField]
		private float _iconPopScale;

		[Header("Audio")]
		[SerializeField]
		private SoundData _upgradeSelectSound;

		[SerializeField]
		private SoundData _revealSound;

		private bool _isInteractionEnabled;

		public BaseGameplayUpgrade Upgrade { get; private set; }

		public int Index { get; private set; }

		public event Action<UIBossChestUpgradeItem> OnUpgradeSelected
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

		public event Action OnRevealComplete
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

		public void Construct(GameplayUpgradeSelection upgradeSelection, int index, Sprite[] rollerIcons)
		{
		}

		public void StartReveal(float rollerDuration)
		{
		}

		private void StartRolling(Sprite[] rollerIcons)
		{
		}

		public void EnableInteraction()
		{
		}

		public void Deactivate()
		{
		}

		private void SetInactiveState()
		{
		}

		private void OnRollerComplete()
		{
		}

		public void ShowFullCard()
		{
		}

		private void ShowCardContainer()
		{
		}

		private void SetupDescriptions(string[] descriptions)
		{
		}

		private void OnButtonClick()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
