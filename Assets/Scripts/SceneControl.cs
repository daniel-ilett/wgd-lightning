using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
	private SceneType sceneType = SceneType.SHOWCASE;

	[SerializeField]
	private ShaderType[] shaderTypes;
	private int index = -1;

	public static SceneControl sceneControl = null;

	private void Awake()
	{
		if (sceneControl == null)
		{
			DontDestroyOnLoad(gameObject);
			sceneControl = this;
		}
		else
			Destroy(gameObject);
		
	}

	private void Update()
	{
		if (Input.GetButtonDown("Next"))
		{
			if(index < shaderTypes.Length + 1 && sceneType == SceneType.SHOWCASE)
				++index;

			if (index < shaderTypes.Length)
			{
				sceneType = (sceneType == SceneType.SHOWCASE) ? SceneType.SCREENSHOT : SceneType.SHOWCASE;
				SceneManager.LoadScene(sceneType == SceneType.SHOWCASE ? "sc_Showcase" : "sc_Screenshot");
			}
			else
			{
				sceneType = SceneType.SCREENSHOT;
				SceneManager.LoadScene("sc_End");
			}
				
		}
		else if (Input.GetButtonDown("Previous"))
		{
			if(index >= -1 && sceneType == SceneType.SCREENSHOT)
				--index;

			if (index >= 0)
			{
				sceneType = (sceneType == SceneType.SHOWCASE) ? SceneType.SCREENSHOT : SceneType.SHOWCASE;
				SceneManager.LoadScene(sceneType == SceneType.SHOWCASE ? "sc_Showcase" : "sc_Screenshot");
			}
			else
			{
				sceneType = SceneType.SHOWCASE;
				SceneManager.LoadScene("sc_Title");
			}
		}
	}

	public ShaderType GetShaderType()
	{
		return shaderTypes[index];
	}
}

public enum SceneType
{
	SCREENSHOT, SHOWCASE
}

public enum ShaderType
{
	GREYSCALE, SEPIA, DEPTH, BLUR, EDGE, CEL
}
