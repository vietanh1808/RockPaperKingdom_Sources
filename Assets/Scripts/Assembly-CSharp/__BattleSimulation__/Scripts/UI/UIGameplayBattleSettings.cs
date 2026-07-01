using UnityEngine;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIGameplayBattleSettings : MonoBehaviour
	{
		[SerializeField]
		private SlotsUnitSpawner _slotsUnitSpawner;

		[SerializeField]
		private UIButtonClick _fightButtonClick;

		[Header("Settings Buttons")]
		[SerializeField]
		private UIButtonClick _spawnSwitcher;

		[SerializeField]
		private UIButtonClick _waveSwitcher;

		[SerializeField]
		private UIButtonClick _fightSwitcher;

		[Header("Settings Marks")]
		[SerializeField]
		private GameObject _spawnOnMark;

		[SerializeField]
		private GameObject _waveOnMark;

		[SerializeField]
		private GameObject _fightOnMark;

		public static bool IsAutoWave { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupView()
		{
		}

		private void OnSpawnSwitchHandler()
		{
		}

		private void OnWaveSwitchHandler()
		{
		}
	}
}
