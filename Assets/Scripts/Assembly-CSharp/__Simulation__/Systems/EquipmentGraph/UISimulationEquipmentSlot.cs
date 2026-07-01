using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.EquipmentGraph
{
	public class UISimulationEquipmentSlot : MonoBehaviour
	{
		[SerializeField]
		private GameObject _equippedContainer;

		[SerializeField]
		private Image _frame;

		[SerializeField]
		private Image _itemImage;

		[SerializeField]
		private Image _typeFrame;

		[SerializeField]
		private Image _typeImage;

		[SerializeField]
		private TMP_Text _levelValue;

		public void Construct(EquipmentItemSnapshot equipmentItemSnapshot, RarityConfig rarityConfig)
		{
		}
	}
}
