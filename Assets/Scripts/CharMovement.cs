﻿using UnityEngine;
using System.Collections;

public class CharMovement : MonoBehaviour {

	public GameObject Lane1PointObject; //left
	public GameObject Lane2PointObject; //middle
	public GameObject Lane3PointObject; //right

	Vector2 ZuperPosition;
	Vector2 Lane1PointX;
	Vector2 Lane2PointX;
	Vector2 Lane3PointX;



	void Start () {


		Lane1PointX = new Vector2 (Lane1PointObject.transform.position.x, this.gameObject.transform.position.y);
		Lane2PointX = new Vector2 (Lane2PointObject.transform.position.x, this.gameObject.transform.position.y);
		Lane3PointX = new Vector2 (Lane3PointObject.transform.position.x, this.gameObject.transform.position.y);

		ZuperPosition = Lane2PointX;
	
	}
	

	void Update () {

		
		transform.position = ZuperPosition;

		if (Input.GetKeyDown (KeyCode.R))Application.LoadLevel("Main");
		
		//***************************** CHAR MOVEMENT SIDEWAYS ***************************************
		if (Input.GetKeyDown (KeyCode.A))
		{
			moveToLeft();
		}

		if (Input.GetKeyDown (KeyCode.D) )
		{
			moveToRight();
			
		}

		foreach (Touch touch in Input.touches) 
		{
			if (touch.phase == TouchPhase.Began)
			{
				if (Input.touchCount > 0)
				{
					Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
					RaycastHit hit;

					if (Physics.Raycast(ray,out hit))
					{
						switch (hit.transform.tag)
						{
						case "Lane1":
							ZuperPosition = Lane1PointX;
							break;
						case "Lane2":
							ZuperPosition = Lane2PointX;
							break;
						case "Lane3":
							ZuperPosition = Lane3PointX;
							break;
						}
					}
				}
			}
		}


		//*****************************************END OF CHAR MOV *****************************************
	}

	void moveToLeft()
	{
		if (ZuperPosition == Lane2PointX )
		{
			ZuperPosition = Lane1PointX;
		}
		
		if (ZuperPosition == Lane3PointX )
		{
			ZuperPosition = Lane2PointX;
		}
	}

	void moveToRight()
	{
		if (ZuperPosition == Lane2PointX )
		{
			ZuperPosition = Lane3PointX;
		}
		
		if (ZuperPosition == Lane1PointX )
		{
			ZuperPosition = Lane2PointX;
		}
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (GameObject.FindWithTag ("Letter")) 
		{
			Destroy(col.gameObject);
			Debug.Log("got *A* ");
		}
	}
}
