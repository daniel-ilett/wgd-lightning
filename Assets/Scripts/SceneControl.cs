using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
	[SerializeField]
	private string previousScene;

	[SerializeField]
	private string nextScene;

	private void Update()
	{
		if (Input.GetButtonDown("Next"))
			SceneManager.LoadScene(nextScene);
		else if (Input.GetButtonDown("Previous"))
			SceneManager.LoadScene(previousScene);
	}

}
