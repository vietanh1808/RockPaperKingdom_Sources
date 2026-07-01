using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.Offers;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Infrastructure
{
	public class MenuSceneBootstrapper : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CInitializeSystemsCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MenuSceneBootstrapper _003C_003E4__this;

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
			public _003CInitializeSystemsCoroutine_003Ed__12(int _003C_003E1__state)
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

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		private GameStateMachine _gameStateMachine;

		private MenuHeroUnlockPresenter _menuHeroUnlockPresenter;

		private MenuUnitCardUnlockPresenter _menuUnitCardUnlockPresenter;

		private MenuPlayerLevelUpController _menuPlayerLevelUpController;

		private MenuFeatureUnlockPresenter _menuFeatureUnlockPresenter;

		private MenuTutorialController _menuTutorialController;

		private AppReviewSystem _appReviewSystem;

		private MenuOfferPresenter _menuOfferPresenter;

		private MenuInterstitialPresenter _menuInterstitialPresenter;

		[Inject]
		public void Inject(UIMenuSceneNavigation uiMenuSceneNavigation, GameStateMachine gameStateMachine, MenuHeroUnlockPresenter menuHeroUnlockPresenter, MenuUnitCardUnlockPresenter menuUnitCardUnlockPresenter, MenuPlayerLevelUpController menuPlayerLevelUpController, MenuFeatureUnlockPresenter menuFeatureUnlockPresenter, MenuTutorialController menuTutorialController, AppReviewSystem appReviewSystem, MenuOfferPresenter menuOfferPresenter, MenuInterstitialPresenter menuInterstitialPresenter)
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CInitializeSystemsCoroutine_003Ed__12))]
		private IEnumerator InitializeSystemsCoroutine()
		{
			return null;
		}

		private void ApplyPendingNavigation()
		{
		}
	}
}
