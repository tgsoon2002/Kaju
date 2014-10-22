using UnityEngine;
using System.Collections;

public class Kaiju : MonoBehaviour 
{
	public int hp =1;
	public bool isEnemy = true;
	public Vector2 speed= new Vector2(10,10);
	public Vector2 direction = new Vector2 (-1, 0);
	public GameManager gameManager;
	private Vector2 movement;
	public int damage = 1;
	GameObject unit; 

	public void Damage(int damageCount)
	{
		hp -= damageCount;
		if (hp <= 0)//dead 
		{
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		Bullet shot = otherCollider.gameObject.GetComponent<Bullet> (); //replace Bullet with projectile later.
		//Is this a shot? // we will need ShotScript 
		if (shot != null) {
			if (shot.isEnemyShot != isEnemy) {
				Damage (shot.damage);
				//Destroy the shot
				Destroy (shot.gameObject);
			} 	
		}
		if (otherCollider.gameObject.tag == "Tank") //Make the tag to 'unit' later 
		{
			print ("I collided with tank");
			gameManager.SendMessage("UnitDamaged", damage, SendMessageOptions.DontRequireReceiver);
		}
	}	
	// Use this for initialization
	//void Start () {
	//
	//}
	
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
