using System;
using System.Collections.Generic;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class TowerUpdateIterator : ITickable, IInitializable, IDisposable
	{
		private readonly BuildingRepository _buildingRepository;

		private readonly LinkedList<TowerBuilding> _circularTowers;

		private readonly Dictionary<TowerBuilding, LinkedListNode<TowerBuilding>> _linkedListNodeByTower;

		private readonly List<BuildingRepository> _additionalRepositories;

		private LinkedListNode<TowerBuilding> _currentTowerNode;

		private float _stepTime;

		private float _accumulatedTime;

		private int _iterationsPerTick;

		public TowerUpdateIterator(BuildingRepository buildingRepository)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void AddRepository(BuildingRepository repository)
		{
		}

		public void RemoveRepository(BuildingRepository repository)
		{
		}

		public void Tick()
		{
		}

		private void SubscribeToRepository(BuildingRepository repository)
		{
		}

		private void UnsubscribeFromRepository(BuildingRepository repository)
		{
		}

		private void OnTowerAdded(TowerBuilding tower)
		{
		}

		private void OnTowerRemoved(TowerBuilding tower)
		{
		}

		private void Clear()
		{
		}

		private void UpdateStepTime()
		{
		}

		private void UpdateIterationsPerTick()
		{
		}
	}
}
