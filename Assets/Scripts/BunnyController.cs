using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour
{
	bool moveUp = false;

	public Sprite standSprite;
	public Sprite jumpSprite;
	public GameObject smokePuff;

	private GameObject flameLGameObject;
	private SpriteRenderer flameLSpriteRenderer;

	private GameObject flameRGameObject;
	private SpriteRenderer flameRSpriteRenderer;

	private GameObject theCactusGameObject;
	private SpriteRenderer theCactusSpriteRenderer;
	// Use this for initialization
	void Start ()
	{
		flameLGameObject = GameObject.Find("flameL");
		flameLSpriteRenderer = flameLGameObject.GetComponent<SpriteRenderer>();
		
		flameRGameObject = GameObject.Find("flameR");
		flameRSpriteRenderer = flameRGameObject.GetComponent<SpriteRenderer>();
		//theFlamesSR = GetComponentInChildren<SpriteRenderer>()[2];
		
		theCactusGameObject = GameObject.FindGameObjectWithTag("flipper");
		theCactusSpriteRenderer = theCactusGameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= 0)
		{
			moveUp = true;
		}else if (transform.position.y >=1)
		{
			moveUp = false;
		}

		if (moveUp == true)
		{
			GetComponent<BunnyMovement>().MoveUp();
			FindObjectOfType<CloudController>().inForeground();
		}
		else
		{
			GetComponent<BunnyMovement>().MoveDown();
			FindObjectOfType<CloudController>().InBackground();
		}


		if (transform.position.y > 0.3)
		{
			GetComponent<SpriteRenderer>().sprite = jumpSprite;
			GetComponent<BunnyMovement>().speed = 2f;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = standSprite;
			GetComponent<BunnyMovement>().speed = 1f;
		}


		if (transform.position.y < 0.05)
		{
			smokePuff.GetComponent<SpriteRenderer>().color =new Color(255,255,255,1);
		}
		else
		{
			smokePuff.GetComponent<SpriteRenderer>().color =new Color(255,255,255,0);
		}
		
		if (transform.position.y > 0.05 && moveUp == true)
		{
			flameLSpriteRenderer.color =new Color(255,255,255,1);
			flameRSpriteRenderer.color =new Color(255,255,255,1);
			theCactusSpriteRenderer.flipX = true;
		}
		else
		{
			flameLSpriteRenderer.color =new Color(255,255,255,0);
			flameRSpriteRenderer.color =new Color(255,255,255,0);
			theCactusSpriteRenderer.flipX = false;
		}
	}
}
