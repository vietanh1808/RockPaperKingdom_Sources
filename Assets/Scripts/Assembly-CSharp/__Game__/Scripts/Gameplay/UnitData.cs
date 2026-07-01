using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "UnitData_", menuName = "TapHub/Data/Unit Data")]
	public class UnitData : SerializedScriptableObject
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private UnitType _unitType;

		[SerializeField]
		private RarityType _rarityType;

		[SerializeField]
		private string _title;

		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private BaseUnit _prefab;

		[Header("Abilities")]
		[SerializeField]
		private AbilityData _mainAbility;

		[SerializeField]
		private AbilityData _secondaryAbility;

		[SerializeField]
		private AbilityData _deathAbility;

		[SerializeField]
		private AbilityData _onDamageReceivedAbility;

		[Header("Stats")]
		[SerializeField]
		private int _experience;

		[SerializeField]
		private int _power;

		[SerializeField]
		private Dictionary<UnitStatType, float> _stats;

		[Header("Priority Order")]
		[SerializeField]
		private List<UnitData> _targetPriorityOrder;

		[Header("Enemy Category")]
		[SerializeField]
		private EnemyCategory _enemyCategory;

		[Header("Castle Damage")]
		[SerializeField]
		private float _castleDamage;

		[Header("Spawn Limits")]
		[SerializeField]
		private int _maxUnitsAmount;

		[Header("Passive Behavior")]
		[SerializeField]
		private bool _isPassive;

		[SerializeField]
		private TargetHolderType _targetHolderType;

		[Header("AI Generation")]
		[TextArea(3, 6)]
		[SerializeField]
		private string _aiDescription;

		private int StatsPower => 0;

		public string Guid => null;

		public UnitType UnitType => default(UnitType);

		public RarityType RarityType => default(RarityType);

		public string Title => null;

		public Sprite Icon => null;

		public BaseUnit Prefab => null;

		public int Experience => 0;

		public int Power => 0;

		public AbilityData MainAbility => null;

		public AbilityData SecondaryAbility => null;

		public AbilityData DeathAbility => null;

		public AbilityData OnDamageReceivedAbility => null;

		public Dictionary<UnitStatType, float> Stats => null;

		public List<UnitData> TargetPriorityOrder => null;

		public EnemyCategory EnemyCategory => default(EnemyCategory);

		public float CastleDamage => 0f;

		public int MaxUnitsAmount => 0;

		public bool IsPassive => false;

		public TargetHolderType TargetHolderType => default(TargetHolderType);

		public string AIDescription => null;

		private int CalculateStatsPower()
		{
			return 0;
		}

		public void GenerateGuid()
		{
		}
	}
}
