using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour 
{
	//Declaring local variables
	public float objSpeed; //This will be the initial speed of the object. 
	float smooth = 15f;
	Vector3 movement;

	void Start () 
	{
		//unitControls = GetComponent<BoxCollider2D>;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		moving (Input.GetAxisRaw ("Horizontal"));

	}
	void moving(float h)
	{
		movement.Set (h, 0f, 0f);
		
		// Normalise the movement vector and make it proportional to the speed per second.
		movement = movement.normalized * objSpeed * Time.deltaTime;
		
		// Move the player to it's current position plus the movement.
		transform.position = Vector3.Lerp (transform.position, transform.position + movement, smooth * Time.deltaTime);
	}
}
