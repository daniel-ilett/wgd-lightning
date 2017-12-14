using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowcaseScene : MonoBehaviour
{
	[SerializeField]
	private GameObject[] showcaseCameras;

	private void Start()
	{
		switch (SceneControl.sceneControl.GetShaderType())
		{
			case ShaderType.GREYSCALE:
				Instantiate(showcaseCameras[0], new Vector3(0.0f, 0.0f, -23.0f), Quaternion.identity);
				break;
			case ShaderType.SEPIA:
				Instantiate(showcaseCameras[1], new Vector3(0.0f, 0.0f, -23.0f), Quaternion.identity);
				break;
			case ShaderType.DEPTH:
				Instantiate(showcaseCameras[2], new Vector3(0.0f, 0.0f, -23.0f), Quaternion.identity);
				break;
			case ShaderType.BLUR:
				Instantiate(showcaseCameras[3], new Vector3(0.0f, 0.0f, -23.0f), Quaternion.identity);
				break;
			case ShaderType.EDGE:
				Instantiate(showcaseCameras[4], new Vector3(0.0f, 0.0f, -23.0f), Quaternion.identity);
				break;
			case ShaderType.CEL:
				Instantiate(showcaseCameras[5], new Vector3(0.0f, 0.0f, -23.0f), Quaternion.identity);
				break;
		}
	}
}
