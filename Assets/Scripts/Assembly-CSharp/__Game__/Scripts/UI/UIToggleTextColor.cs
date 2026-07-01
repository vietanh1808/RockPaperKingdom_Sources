using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.UI
{
	[RequireComponent(typeof(Toggle))]
	public class UIToggleTextColor : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _text;

		[SerializeField]
		private Color _onColor;

		[SerializeField]
		private Color _offColor;

		private Toggle _toggle;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnToggleValueChanged(bool isOn)
		{
		}

		private void UpdateTextColor(bool isOn)
		{
		}
	}
}
