using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyMovement : MonoBehaviour {

	public float speed = 1;

	public void MoveUp()
	{
		transform.Translate(Vector2.up*speed*Time.deltaTime);
	}

	public void MoveDown()
	{
		transform.Translate(-Vector2.up * speed * Time.deltaTime);
	}

}
