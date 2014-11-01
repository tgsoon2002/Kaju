using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public Vector2 speed= new Vector2(10,10);
	public Vector2 direction = new Vector2 (-1, 0);
	// Use this for initialization
//	void Start () {
//	
	//}
	private Vector2 movement;
	// Update is called once per frame
	void Update () {
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
