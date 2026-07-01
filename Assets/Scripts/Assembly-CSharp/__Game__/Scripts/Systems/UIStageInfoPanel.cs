using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStageInfoPanel : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSnapToSelectedElement_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIStageInfoPanel _003C_003E4__this;

			object IEnumerator<object>.Current
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
			public _003CSnapToSelectedElement_003Ed__33(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private UIButtonClick _closeButton;

		[SerializeField]
		private UIButtonClick _goToStageButton;

		[SerializeField]
		private TMP_Text _goToStageText;

		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private RectTransform _contentContainer;

		[SerializeField]
		private UIStageChestGroupElement _groupElementPrefab;

		[Header("Mode Tabs")]
		[SerializeField]
		private UIStageModeTabPair _tabPair;

		[SerializeField]
		private GameObject _normalModeTabAlert;

		[SerializeField]
		private GameObject _hardModeTabAlert;

		private StageChestSystem _stageChestSystem;

		private StageSystem _stageSystem;

		private StagesCollection _stagesCollection;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		private DiContainer _diContainer;

		private readonly List<UIStageChestGroupElement> _groupElements;

		private UIStageChestGroupElement _selectedGroupElement;

		private StageModeType _displayedModeType;

		public UIStageChestGroupElement FirstGroupElement => null;

		public event Action OnElementsCreated
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
		public void Inject(StageChestSystem stageChestSystem, StageSystem stageSystem, StagesCollection stagesCollection, UIMenuSceneNavigation uiMenuSceneNavigation, DiContainer diContainer)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SwitchToMode(StageModeType modeType)
		{
		}

		private void RebuildForMode(StageModeType modeType)
		{
		}

		private void CreateAllElements(StageModeType modeType)
		{
		}

		private void OnChestStateChanged()
		{
		}

		private void RefreshAllElements()
		{
		}

		private void RemoveAllElements()
		{
		}

		private void SelectGroupByStageIndex(int stageIndex)
		{
		}

		private void OnGroupSelected(int stageIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CSnapToSelectedElement_003Ed__33))]
		private IEnumerator SnapToSelectedElement()
		{
			return null;
		}

		private void RefreshAlerts()
		{
		}

		private void OnGoToStageClicked()
		{
		}

		private void OnCloseButtonClicked()
		{
		}
	}
}
