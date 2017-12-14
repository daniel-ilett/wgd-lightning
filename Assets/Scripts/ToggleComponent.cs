using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ToggleComponent : MonoBehaviour
{
	private bool active = false;

	private void Update()
	{
		if(Input.GetButtonDown("Toggle"))
		{
			active = !active;
			GetComponent<PPBase>().enabled = active;
		}
	}
}
