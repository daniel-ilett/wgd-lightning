using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleComponent : MonoBehaviour
{
	[SerializeField]
	private EffectType type;

	private bool active = false;

	private void Update()
	{
		if(Input.GetButtonDown("Toggle"))
		{
			active = !active;
			switch (type)
			{
				case EffectType.Greyscale:
					GetComponent<PPGreyscale>().enabled = active;
					break;
				case EffectType.Sepia:
					GetComponent<PPSepia>().enabled = active;
					break;
				case EffectType.Blur:
					GetComponent<PPGaussianBlur>().enabled = active;
					break;
				case EffectType.Depth:
					GetComponent<PPDepth>().enabled = active;
					break;
				case EffectType.Edge:
					GetComponent<PPSobelEdge>().enabled = active;
					break;
			}
		}
	}
}

enum EffectType
{
	Greyscale, Sepia, Blur, Depth, Edge, Cel
}

