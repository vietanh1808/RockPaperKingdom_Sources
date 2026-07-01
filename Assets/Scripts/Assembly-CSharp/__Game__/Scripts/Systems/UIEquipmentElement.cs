using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentElement : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _frame;

		[SerializeField]
		private Image _itemImage;

		[SerializeField]
		private Image _typeFrame;

		[SerializeField]
		private Image _typeImage;

		[SerializeField]
		private TMP_Text _levelValue;

		private Action<EquipmentItem> _onButtonClicked;

		private EquipmentItem _equipmentItem;

		private RarityConfig _rarityConfig;

		private bool _isSubscribed;

		public event Action<EquipmentItem> OnConstructed
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

		public event Action OnLevelChanged
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

		public void Construct(EquipmentItem equipmentItem, RarityConfig rarityConfig, Action<EquipmentItem> onButtonClicked)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Subscribe()
		{
		}

		private void Unsubscribe()
		{
		}

		private void SetupView()
		{
		}

		private void RefreshLevel(EquipmentItem equipmentItem)
		{
		}

		private void InvokeButtonClick()
		{
		}
	}
}
