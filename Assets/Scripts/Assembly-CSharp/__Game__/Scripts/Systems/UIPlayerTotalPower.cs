using TMPro;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIPlayerTotalPower : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _value;

		private PlayerStaticStatsRepository _playerStaticStatsRepository;

		[Inject]
		private void Inject(PlayerStaticStatsRepository playerStaticStatsRepository)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTotalPowerChanged(float value)
		{
		}
	}
}
