using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "AbilityData", menuName = "TapHub/Ability/AbilityData")]
	public class AbilityData : SerializedScriptableObject
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private string _title;

		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private AbilityObject _abilityObjectPrefab;

		[SerializeField]
		private AbilityObject _hitEffectObjectPrefab;

		[SerializeField]
		private AbilityObject _sourceEffectObjectPrefab;

		[SerializeField]
		private DamageType _damageType;

		[SerializeField]
		private RangeType _rangeType;

		[Header("MAIN CAST")]
		[SerializeField]
		private AbilityCastType _abilityCastType;

		[Header("SPAWN TARGET")]
		[SerializeField]
		private AbilitySpawnType _abilitySpawnType;

		[SerializeField]
		private TargetProviderType _spawnTargetProviderType;

		[Header("ENEMY TARGET")]
		[SerializeField]
		private TargetProviderType _enemyTargetProviderType;

		[Header("SECONDARY CAST")]
		[SerializeField]
		private AbilityData _castOnHit;

		[Header("DEBUFFS")]
		[SerializeField]
		private List<BaseDebuffData> _debuffs;

		[Header("BASE STATS")]
		[SerializeField]
		private Dictionary<AbilityStatType, float> _floatStats;

		[Header("ANIMATION")]
		[SerializeField]
		private bool _showAnimation;

		[SerializeField]
		private float _preparingCastTime;

		[Header("AUDIO")]
		[SerializeField]
		private SoundBundleData _castSound;

		[SerializeField]
		private SoundBundleData _hitSound;

		public string Title => null;

		public Sprite Icon => null;

		public AbilityObject AbilityObjectPrefab => null;

		public AbilityObject HitEffectObjectPrefab => null;

		public AbilityObject SourceEffectObjectPrefab => null;

		public DamageType DamageType => default(DamageType);

		public RangeType RangeType => default(RangeType);

		public AbilitySpawnType AbilitySpawnType => default(AbilitySpawnType);

		public TargetProviderType SpawnTargetProviderType => default(TargetProviderType);

		public AbilityCastType AbilityCastType => default(AbilityCastType);

		public TargetProviderType EnemyTargetProviderType => default(TargetProviderType);

		public AbilityData CastOnHit => null;

		public List<BaseDebuffData> Debuffs => null;

		public Dictionary<AbilityStatType, float> FloatStats => null;

		public float PreparingCastTime => 0f;

		public bool ShowAnimation => false;

		public SoundBundleData CastSound => null;

		public SoundBundleData HitSound => null;

		public string Guid => null;
	}
}
