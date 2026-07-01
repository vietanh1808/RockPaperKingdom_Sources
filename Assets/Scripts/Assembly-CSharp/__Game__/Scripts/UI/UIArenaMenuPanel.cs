using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UIArenaMenuPanel : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _fightButton;

		[Header("Rank")]
		[SerializeField]
		private TMP_Text _rankText;

		[SerializeField]
		private TMP_Text _tierNameText;

		[SerializeField]
		private Image _tierIcon;

		[Header("Tickets")]
		[SerializeField]
		private TMP_Text _ticketCountText;

		[SerializeField]
		private GameObject _ticketTimerContainer;

		[SerializeField]
		private TMP_Text _ticketTimerText;

		[SerializeField]
		private UIButtonClick _buyTicketsButton;

		private GameStateMachine _gameStateMachine;

		private ArenaSystem _arenaSystem;

		private ArenaTicketSystem _arenaTicketSystem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		public UIButtonClick FightButton => null;

		[Inject]
		public void Construct(GameStateMachine gameStateMachine, ArenaSystem arenaSystem, ArenaTicketSystem arenaTicketSystem, UIMenuSceneNavigation uiMenuSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateRankDisplay()
		{
		}

		private void OnTicketAmountChanged(int amount)
		{
		}

		private void OnTicketTimeChanged()
		{
		}

		private void UpdateTicketDisplay()
		{
		}

		private void UpdateTimerDisplay()
		{
		}

		private void OnFightButtonClicked()
		{
		}

		private void OnBuyTicketsButtonClicked()
		{
		}

		private void OpenPurchaseArenaTicketPopup()
		{
		}
	}
}
