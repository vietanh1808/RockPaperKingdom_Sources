using System;
using System.Collections.Generic;
using Zenject;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Systems
{
	public class CooldownSystem : ITickable
	{
		private const float UPDATE_RATE = 1f;

		private readonly Dictionary<string, Cooldown> _cooldownItems;

		private readonly Dictionary<string, CooldownListener> _cooldownListeners;

		private readonly List<string> _cooldownToRemove;

		private float _updateTimer;

		private bool _hasCooldownToRemove;

		public Dictionary<string, DateTime> CooldownToRecoveryTime()
		{
			return null;
		}

		public void RecoveryTimeToCooldown(Dictionary<string, DateTime> recoveryTime)
		{
		}

		public void AddCooldown(string guid, TimeData cooldownTime)
		{
		}

		public void AddCooldown(string guid, TimeSpan cooldownTime)
		{
		}

		public void SetCooldown(string guid, float seconds)
		{
		}

		public void Tick()
		{
		}

		public void AddListener(CooldownListener cooldownListener)
		{
		}

		public void RemoveListener(CooldownListener cooldownListener)
		{
		}

		private void AddCooldown(string guid, float seconds)
		{
		}

		private Cooldown GetCooldown(string guid)
		{
			return null;
		}

		private void DecreaseAllCooldowns()
		{
		}

		private void ActivateListener(string guid, float cooldown)
		{
		}

		private void DecreaseCooldown(KeyValuePair<string, Cooldown> cooldownItem)
		{
		}

		private void ProcessCooldownChange(string guid, Cooldown cooldown)
		{
		}

		private void HandleCooldownRemoval()
		{
		}

		private void RemoveAllCooldown()
		{
		}

		private void RemoveCooldown(string guid)
		{
		}

		private float GetTotalSeconds(TimeData cooldownTime)
		{
			return 0f;
		}

		private float GetTotalSeconds(TimeSpan cooldownTime)
		{
			return 0f;
		}
	}
}
