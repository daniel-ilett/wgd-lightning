using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class PPSobelEdge : MonoBehaviour
{
	[SerializeField]
	private Vector2 delta = new Vector2(0.01f, 0.01f);

	[SerializeField]
	private EdgeType type;

	private Material mat;

	private void Awake()
	{
		if(type == EdgeType.EdgeOnly)
			mat = new Material(Shader.Find("Hidden/PPSobelEdge"));
		else
			mat = new Material(Shader.Find("Hidden/PPSobelCelShaded"));
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
		mat.SetFloat("_DeltaX", delta.x);
		mat.SetFloat("_DeltaY", delta.y);

		Graphics.Blit(src, dst, mat);
	}

	enum EdgeType
	{
		EdgeOnly, CelShaded
	}
}
