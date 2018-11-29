using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUpAndDown : MonoBehaviour {

	public void ScaleUp()
	{
		GetComponent<RectTransform>().localScale = new Vector2(1.1f,1.1f);
	}

	public void ScaleDown()
	{
		GetComponent<RectTransform>().localScale = new Vector2(1,1);
	}
}
