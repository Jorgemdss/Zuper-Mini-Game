using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	public GameObject Lane1PointObject; //left
	public GameObject Lane2PointObject; //middle
	public GameObject Lane3PointObject; //right

	Vector2 ZuperPosition;
	Vector2 Lane1PointX;
	Vector2 Lane2PointX;
	Vector2 Lane3PointX;

	public static string myLetterValue;



	void Start () {
		myLetterValue = "_" ;// isto e como se tivesse null

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

			Debug.Log("name: " + col.gameObject.transform.name);


			switch (col.gameObject.transform.name)//switch para ver que letra choca
			{
			case "a(Clone)":
				myLetterValue = "a";
				Debug.Log(myLetterValue);
				break;
			case "e(Clone)":
				myLetterValue = "e";
				Debug.Log(myLetterValue);
				break;
			case "i(Clone)":
				myLetterValue = "i";
				Debug.Log(myLetterValue);
				break;
			case "c(Clone)":
				myLetterValue = "c";
				Debug.Log(myLetterValue);
				break;
			default:
				myLetterValue = "_";
				Debug.Log(myLetterValue);
				break;
			}

			Destroy(col.gameObject);
			
		}
	}
	
}
