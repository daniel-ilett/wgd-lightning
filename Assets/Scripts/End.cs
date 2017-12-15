using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetButton("Cancel"))
		{
			Debug.Log("Quit");

//#if UNITY_EDITOR
//			UnityEditor.EditorApplication.isPlaying = false;
//#else
			Application.Quit();
//#endif
		}
	}
}
