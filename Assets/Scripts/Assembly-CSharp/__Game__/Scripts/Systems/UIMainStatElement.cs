using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIMainStatElement : MonoBehaviour
	{
		[SerializeField]
		private PlayerStatType _playerStatType;

		[SerializeField]
		private Image _statIcon;

		[SerializeField]
		private TMP_Text _statValue;

		[SerializeField]
		private TMP_Text _statTitle;

		private const string STRING_FORMAT = "F0";

		private const float ANIMATION_DURATION = 0.25f;

		private float _currentStatValue;

		private Tween _statTween;

		private StaticStatSystem _staticStatSystem;

		private PlayerStatInfoCollection _playerStatInfoCollection;

		[Inject]
		public void Inject(StaticStatSystem staticStatSystem, PlayerStatInfoCollection playerStatInfoCollection)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupView()
		{
		}

		private void RefreshStatAnimated()
		{
		}

		private void RefreshStatText()
		{
		}
	}
}
