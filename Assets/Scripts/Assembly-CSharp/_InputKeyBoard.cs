using System;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("1Enwer/Input/_KeyBoard")]
public class _InputKeyBoard : MonoBehaviour
{
	public enum PressType
	{
		GetKey = 0,
		GetKeyDown = 1,
		GetKeyUp = 2
	}

	[Serializable]
	public class KeyCodeEvent
	{
		public KeyCode keyCode;

		public UnityEvent function;
	}

	public PressType pressType;

	public KeyCodeEvent[] keyBoardGetKey;

	private void Update()
	{
	}

	public bool KeyBoardIsPressed(PressType _pressType, KeyCode keycode)
	{
		return false;
	}
}
