using System;
using System.Runtime.CompilerServices;
using LeTai.TrueShadow;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class UIUpgradeItem : MonoBehaviour
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private TMP_Text _title;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text[] _descriptionTexts;

		[SerializeField]
		private TMP_Text _hintText;

		[SerializeField]
		private GameObject _bestPick;

		[SerializeField]
		private GameObject _newMark;

		[Header("Rarity")]
		[SerializeField]
		private TrueShadow _outlineShadow;

		[Header("Audio")]
		[SerializeField]
		private SoundData _upgradeSelectSound;

		private RarityConfig _rarityConfig;

		private UnitCardItem _unitCardItem;

		public BaseGameplayUpgrade Upgrade { get; private set; }

		public int Index { get; private set; }

		public event Action<UIUpgradeItem> OnUpgradeSelected
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

		public void Construct(GameplayUpgradeSelection upgradeSelection, int index, UnitCardItem unitCardItem, RarityConfig rarityConfig)
		{
		}

		public void Deactivate()
		{
		}

		private void SetupOutlineColor()
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

		private void RefreshNewMark()
		{
		}
	}
}
