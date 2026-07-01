using DG.Tweening;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UIPowerText : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _powerValue;

		[SerializeField]
		private float _countDuration;

		private PlayerPowerSystem _playerPowerSystem;

		private int _displayValue;

		private Tween _countTween;

		[Inject]
		private void Inject(PlayerPowerSystem playerPowerSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPowerChanged(int oldPower, int newPower)
		{
		}

		private void SetValueImmediate(int power)
		{
		}

		private void AnimateValue(int newPower)
		{
		}

		private void KillTween()
		{
		}
	}
}
