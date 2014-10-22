using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitSwitching : MonoBehaviour 
{
	//Declaring local variables
	//List<Camera> tankCameras; 
	GameObject[] tanks;
	private int numTanks; 
	Camera unitCams; 
	private int unitFocused;
	private Vector3 newPosition;
	public float smoothRate = 0.5f;
	private Vector2 velocity;
	private bool focused;
//	void Awake()
//	{
//		newPosition = gameObject.transform.position;
//	}

	// Use this for initialization
	void Start () 
	{
		tanks = GameObject.FindGameObjectsWithTag ("Tank");
		numTanks = GameObject.FindGameObjectsWithTag ("Tank").Length;
		unitFocused = 0;
		gameObject.transform.position = new Vector3(tanks[unitFocused].transform.position.x,
		                                            tanks[unitFocused].transform.position.y,
		                                            gameObject.transform.position.z);
		velocity = new Vector2 (smoothRate, smoothRate);
		focused = true;
		EnableControl (tanks, numTanks);


	}
	
	// Update is called once per frame
	void Update () 
	{
		//gameObject.transform.position//follows movement of tank smoothly.
		Vector2 camChase2D;
		Vector3 newPosCam2D;


		if(Input.GetKeyDown (KeyCode.Tab))
		{
		
			if(unitFocused < numTanks)
			{
				focused=true;
				Debug.Log ("Index is: " + unitFocused);
				EnableControl(tanks, numTanks);
//				newPosition = new Vector3(tanks[unitFocused].transform.position.x,
//				                          tanks[unitFocused].transform.position.y,
//				                          gameObject.transform.position.z);
//				gameObject.transform.position = Vector3.Lerp (transform.position, newPosition, Time.deltaTime);
				gameObject.transform.position = new Vector3(tanks[unitFocused].transform.position.x,
				                                            tanks[unitFocused].transform.position.y,
				                                            gameObject.transform.position.z);

//				camChase2D.x = Mathf.SmoothDamp(gameObject.transform.position.x, tanks[unitFocused].transform.position.x, ref velocity.x, smoothRate);
//				camChase2D.y = Mathf.SmoothDamp(gameObject.transform.position.y, tanks[unitFocused].transform.position.y, ref velocity.y, smoothRate);
//				newPosCam2D = new Vector3(camChase2D.x, camChase2D.y, gameObject.transform.position.z);
//				gameObject.transform.position = Vector3.Slerp(gameObject.transform.position, newPosCam2D, Time.time);

				unitFocused++;
			}
			else
			{
				focused= true;
				unitFocused = 0;
				gameObject.transform.position = new Vector3(tanks[unitFocused].transform.position.x,
				                                            tanks[unitFocused].transform.position.y,
				                                            gameObject.transform.position.z);
				EnableControl(tanks, numTanks);
				unitFocused++;
			}


		}
	}

	void EnableControl(GameObject[] unit, int numUnit)
	{
		for(int i = 0; i < numUnit; i++)
		{
			if(i == unitFocused)
			{
				unit[i].GetComponent<MoveObject>().enabled = true;
			}
			else
			{
				unit[i].GetComponent<MoveObject>().enabled = false;
			}
		}
	}

	void LateUpdate()
	{
		if ((focused == true) /*&&(unitFocused < numTanks)*/) 
		{
			if (unitFocused>0)
			{
				gameObject.transform.position = new Vector3(tanks[unitFocused-1].transform.position.x - 2.0f,
			                                            tanks[unitFocused-1].transform.position.y,
			                                            gameObject.transform.position.z);

			}
			//else
			//{
			//	gameObject.transform.position = new Vector3(tanks[numTanks-1].transform.position.x,
			//	                                            tanks[numTanks-1].transform.position.y,
			//	                                            gameObject.transform.position.z);
			//}
		}
	}

	/*void CycleCams(List<Camera> c, int focus, int numUnit)
	{
		for(int i = 0; i < numUnit; i++)
		{
			if(i == focus)
			{
				tankCameras[i].camera.active = true;
			}
			else
			{
				tankCameras[i].camera.active = false;
			}
		}
	}*/
	
}

