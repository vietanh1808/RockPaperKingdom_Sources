using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class MenuTutorialController : MonoBehaviour
	{
		[SerializeField]
		private List<UIBaseMenuTutorial> _tutorials;

		private readonly List<string> _tutorialGuids;

		private MenuTutorialSystem _menuTutorialSystem;

		private EventQueueSystem _eventQueueSystem;

		[Inject]
		private void Inject(MenuTutorialSystem menuTutorialSystem, EventQueueSystem eventQueueSystem)
		{
		}

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void TryDisplayMenuTutorial(string guid)
		{
		}

		private void UpdateGuids()
		{
		}
	}
}
