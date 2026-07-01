using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using TMPro;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.EquipmentGraph
{
	public class UISimulationEquipmentElement : SerializedMonoBehaviour
	{
		[OdinSerialize]
		private Dictionary<EquipmentTypeData, UISimulationEquipmentSlot> _slotByType;

		[SerializeField]
		private TMP_Text _equipmentCoefficientText;

		public void Construct(SimulationSnapshot simulationSnapshot, RarityConfig rarityConfig)
		{
		}

		private void UpdateEquipmentCoefficient(SimulationSnapshot simulationSnapshot)
		{
		}
	}
}
