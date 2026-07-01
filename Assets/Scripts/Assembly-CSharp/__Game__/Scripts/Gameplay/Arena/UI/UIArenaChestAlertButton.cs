using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaChestAlertButton : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private ArenaChestSystem _arenaChestSystem;

		[Inject]
		private void Inject(ArenaChestSystem arenaChestSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshAlert()
		{
		}
	}
}
