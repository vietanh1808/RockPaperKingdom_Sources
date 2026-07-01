using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class UIGameplayTimeView : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _time;

		[SerializeField]
		private TMP_Text _progress;

		private WaveSystem _waveSystem;

		[Inject]
		private void Inject(WaveSystem waveSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshView()
		{
		}
	}
}
