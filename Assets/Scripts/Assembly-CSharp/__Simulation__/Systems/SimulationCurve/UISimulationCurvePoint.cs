using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace __Simulation__.Systems.SimulationCurve
{
	public class UISimulationCurvePoint : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[SerializeField]
		private Image _image;

		[Header("Message")]
		[SerializeField]
		private Transform _container;

		[SerializeField]
		private TMP_Text _message;

		public string Title { get; private set; }

		public int Index { get; private set; }

		public Vector3 AnchoredPosition { get; private set; }

		public event Action<UISimulationCurvePoint> OnPointerEntered
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnPointerExited
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetValue(int amount)
		{
		}

		public void SetPosition(Vector3 anchoredPosition)
		{
		}

		public void SetColor(Color color)
		{
		}

		public void ShowValue(bool isOn)
		{
		}

		public void SetOptions(string title, int index)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
}
