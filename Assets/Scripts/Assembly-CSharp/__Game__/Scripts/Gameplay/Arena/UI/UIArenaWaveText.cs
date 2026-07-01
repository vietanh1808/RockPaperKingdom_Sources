using TMPro;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaWaveText : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _waveText;

		private ArenaWaveSystem _arenaWaveSystem;

		[Inject]
		private void Inject(ArenaWaveSystem arenaWaveSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateWaveText()
		{
		}
	}
}
