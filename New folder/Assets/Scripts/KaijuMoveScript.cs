using UnityEngine;
using System.Collections;

public class KaijuMoveScript : MonoBehaviour {

	public Vector2 speed= new Vector2(10,10);
	public Vector2 direction = new Vector2 (-1, 0);
	private Vector2 movement;
	public int damage =1;
	
	// Update is called once per frame
	void Update () 
	{
		movement=new Vector2
			(speed.x*direction.x,
			 speed.x*direction.y);
		
	}
	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
		//apply movement to the rigidbody
	}
}
