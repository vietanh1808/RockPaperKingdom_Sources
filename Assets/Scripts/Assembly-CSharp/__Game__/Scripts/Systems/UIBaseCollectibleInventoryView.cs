using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseCollectibleInventoryView<TSystem, TItem, TItemData> : MonoBehaviour where TSystem : BaseCollectibleSystem<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		[SerializeField]
		private RectTransform _parentLayout;

		[SerializeField]
		private UIBaseCollectibleInventoryElement<TItem, TItemData> _elementPrefab;

		protected readonly Dictionary<TItem, UIBaseCollectibleInventoryElement<TItem, TItemData>> ElementDictionary;

		protected TSystem CollectibleSystem;

		private DiContainer _diContainer;

		private RarityConfig _rarityConfig;

		private UICollectibleSorter<TSystem, TItem, TItemData> _sorter;

		public event Action OnInitialized
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
		public void Inject(DiContainer diContainer, TSystem collectibleSystem, RarityConfig rarityConfig)
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void InvokeInitialized()
		{
		}

		private void CreateAllElements()
		{
		}

		private void RemoveAllElements()
		{
		}

		private void AddElement(TItem collectibleItem)
		{
		}

		private void RemoveElement(TItem collectibleItem)
		{
		}

		private void SortElements()
		{
		}

		protected abstract void ElementButtonClicked(TItem collectibleItem);
	}
}
