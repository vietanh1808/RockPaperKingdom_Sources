using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIGroupedUnitCardInventoryView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCollectDeployedUnitCards_003Ed__24 : IEnumerable<UnitCardItem>, IEnumerable, IEnumerator<UnitCardItem>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private UnitCardItem _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public UIGroupedUnitCardInventoryView _003C_003E4__this;

			private List<HeroItem>.Enumerator _003C_003E7__wrap1;

			private List<UnitCardItemData>.Enumerator _003C_003E7__wrap2;

			UnitCardItem IEnumerator<UnitCardItem>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCollectDeployedUnitCards_003Ed__24(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<UnitCardItem> IEnumerable<UnitCardItem>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly Dictionary<BuildingType, int> BUILDING_TYPE_SORT_ORDER;

		[SerializeField]
		private RectTransform _deployedCardsContainer;

		[SerializeField]
		private RectTransform _heroSectionsContainer;

		[SerializeField]
		private UIUnitCardSection _sectionPrefab;

		[SerializeField]
		private UIUnitCardSectionTitle _titlePrefab;

		[SerializeField]
		private UIUnitCardInventoryElement _elementPrefab;

		[SerializeField]
		private TMP_Text _deployedCardsTitleText;

		private HeroSystem _heroSystem;

		private UnitCardSystem _unitCardSystem;

		private RarityConfig _rarityConfig;

		private DiContainer _diContainer;

		private UIMenuSceneNavigation _menuSceneNavigation;

		private readonly List<UIUnitCardInventoryElement> _deployedElements;

		private readonly List<UIUnitCardSectionTitle> _heroTitles;

		private readonly List<UIUnitCardSection> _heroSections;

		public IReadOnlyList<UIUnitCardSection> HeroSections => null;

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
		private void Inject(HeroSystem heroSystem, UnitCardSystem unitCardSystem, RarityConfig rarityConfig, DiContainer diContainer, UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PopulateDeployedCards()
		{
		}

		[IteratorStateMachine(typeof(_003CCollectDeployedUnitCards_003Ed__24))]
		private IEnumerable<UnitCardItem> CollectDeployedUnitCards()
		{
			return null;
		}

		private int GetBuildingTypeSortOrder(BuildingType buildingType)
		{
			return 0;
		}

		private void PopulateHeroSections()
		{
		}

		private void ClearDeployedCards()
		{
		}

		private void ClearHeroSections()
		{
		}

		private void OnDeployedCardClicked(UnitCardItem unitCardItem)
		{
		}
	}
}
