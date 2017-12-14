using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class SnapshotScene : MonoBehaviour
{
	[SerializeField]
	private Text titleText;

	[SerializeField]
	private Image leftImage;

	[SerializeField]
	private Image rightImage;

	[SerializeField]
	private SnapshotData[] snapshotData;

	public void Start()
	{
		switch (SceneControl.sceneControl.GetShaderType())
		{
			case ShaderType.GREYSCALE:
				SetElements(snapshotData[0]);
				break;
			case ShaderType.SEPIA:
				SetElements(snapshotData[1]);
				break;
			case ShaderType.DEPTH:
				SetElements(snapshotData[2]);
				break;
			case ShaderType.BLUR:
				SetElements(snapshotData[3]);
				break;
			case ShaderType.EDGE:
				SetElements(snapshotData[4]);
				break;
			case ShaderType.CEL:
				SetElements(snapshotData[5]);
				break;
		}
	}

	private void SetElements(SnapshotData data)
	{
		titleText.text = data.title;
		leftImage.sprite = data.left;
		rightImage.sprite = data.right;
	}
}

[System.Serializable]
public struct SnapshotData
{
	public string title;
	public Sprite left;
	public Sprite right;
}
