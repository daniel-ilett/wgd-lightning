using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class PPDepth : MonoBehaviour
{
	private Material mat;
	private Camera cam;

	private void Awake()
	{
		mat = new Material(Shader.Find("Hidden/PPDepth"));
		cam = GetComponent<Camera>();

		cam.depthTextureMode = DepthTextureMode.Depth;
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
		Graphics.Blit(src, dst, mat);
	}
}
