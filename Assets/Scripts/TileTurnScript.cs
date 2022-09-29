using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileTurnScript : MonoBehaviour
{
	public Image image;
	public Sprite sprite;
	private void Awake()
	{
		image = GetComponent<Image>();
	}

	
}
