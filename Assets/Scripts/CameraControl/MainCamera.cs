using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainCamera : MonoBehaviour 
{
	//Declaring local variables
	//List<Camera> tankCameras; 
	public Transform target;            // The position that that camera will be following.
	public float smoothing = 5f;        // The speed with which the camera will be following.
	Vector3 offset;

	GameObject[] tanks;
	int numTanks,currenttank; 
	Camera unitCams; 
	int unitFocused;
	Vector3 newPosition;
	public float smoothRate = 0.5f;
	Vector2 velocity;
	bool focused;
//	void Awake()
//	{
//		newPosition = gameObject.transform.position;
//	}

	// Use this for initialization
	void Start () 
	{
		currenttank = 0;
		offset = transform.position - target.position;
		tanks = GameObject.FindGameObjectsWithTag ("Tank");
		numTanks = GameObject.FindGameObjectsWithTag ("Tank").Length;
		//unitFocused = 0;
		//gameObject.transform.position = new Vector2(tanks[unitFocused].transform.position.x,		                                            tanks[unitFocused].transform.position.y);
		//velocity = new Vector2 (smoothRate, smoothRate);
		//focused = true;
		//EnableControl (tanks, numTanks);
	}
	void Update()
	{
		if (Input.GetButton ("Switch Target")) 
		{
			currenttank++;
			target = tanks[currenttank].transform;
		}
	}
	void FixedUpdate ()
	{
		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
	void SwitchTarget()
	{

	}
	void EnableControl(GameObject[] unit, int numUnit)
	{
		for(int i = 0; i < numUnit; i++)
		{
			if(i == unitFocused)
			{
				unit[i].GetComponent<TankMovement>().enabled = true;
			}
			else
			{
				unit[i].GetComponent<TankMovement>().enabled = false;
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
		}
	}

			//else
			//{
			//	gameObject.transform.position = new Vector3(tanks[numTanks-1].transform.position.x,
			//	                                            tanks[numTanks-1].transform.position.y,
			//	                                            gameObject.transform.position.z);
			//}
	
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
	//gameObject.transform.position//follows movement of tank smoothly.
	//Vector2 camChase2D;
	//Vector2 newPosCam2D;
	
	/*
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
				gameObject.transform.position = new Vector2(tanks[unitFocused].transform.position.x,
				                                            tanks[unitFocused].transform.position.y);
				EnableControl(tanks, numTanks);
				unitFocused++;
			}


		}
*/
}

