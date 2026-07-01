using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay
{
	public class UnitUpdateIterator
	{
		private readonly UnitRepository _unitRepository;

		private readonly LinkedList<BaseUnit> _circularUnits;

		private readonly Dictionary<BaseUnit, LinkedListNode<BaseUnit>> _linkedListNodeByUnit;

		private LinkedListNode<BaseUnit> _currentUnitNode;

		private float _stepTime;

		private float _accumulatedTime;

		private int _iterationsPerTick;

		public UnitUpdateIterator(UnitRepository unitRepository)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void Tick()
		{
		}

		private void OnUnitAdded(BaseUnit unit)
		{
		}

		private void OnUnitRemoved(BaseUnit unit)
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
