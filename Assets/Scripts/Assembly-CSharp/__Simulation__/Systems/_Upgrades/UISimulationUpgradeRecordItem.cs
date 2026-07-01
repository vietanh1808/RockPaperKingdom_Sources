using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Gameplay;

namespace __Simulation__.Systems._Upgrades
{
	public class UISimulationUpgradeRecordItem : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _textMeshPro;

		[SerializeField]
		private Image _icon;

		public void Construct(int index, BaseGameplayUpgrade upgrade, bool isCurrentIndex)
		{
		}
	}
}
