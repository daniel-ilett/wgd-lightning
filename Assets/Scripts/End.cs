using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetButtonDown("Cancel"))
			Application.Quit();
	}
}
