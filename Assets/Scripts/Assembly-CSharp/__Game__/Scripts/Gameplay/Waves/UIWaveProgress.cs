using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class UIWaveProgress : MonoBehaviour
	{
		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private Image _fillImage;

		[SerializeField]
		private Transform _pointer;

		[SerializeField]
		private TMP_Text _durationText;

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

		private void OnWaveStateChanged()
		{
		}

		private void OnWaveTimeUpdate()
		{
		}
	}
}
