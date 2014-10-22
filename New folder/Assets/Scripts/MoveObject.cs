using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour 
{
	//Declaring local variables
	public float objSpeed = 10.0f; //This will be the initial speed of the object. 
	Vector2 direction = new Vector2(0,0);

	// Use this for initialization
	void Start () 
	{
		//unitControls = GetComponent<BoxCollider2D>;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//Declaring local variables
		float move = 0;
		if(Input.GetKey("a")/*Down(KeyCode.A)*/)
		{	
			move = -1.0f;
			rigidbody2D.velocity = new Vector2(move * objSpeed, rigidbody2D.velocity.y);
		}

		if(Input.GetKey("d")/*Down(KeyCode.D)*/)
		{
			move = 1.0f;
			rigidbody2D.velocity = new Vector2(move * objSpeed, rigidbody2D.velocity.y);
		}
	}
}
