using UnityEngine;
using System.Collections;

public class Kaiju : MonoBehaviour 
{
	public int hp ;
	//public bool isEnemy = true;
	public float speed = 5f;
	public GameManager gameManager;
	public int damage = 1;

	GameObject unit; 

	void Start(){

	}

	void Update () {

		//movement=new Vector2	(speed.x*direction.x,			 speed.x*direction.y);
		
	}
	public void TakeDamage(int damageCount)
	{
		if (hp <= 0) {//dead
			Destroy (gameObject);
		}
		else {
			hp -= damageCount;		
		}
	}
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
	//	Bullet shot = otherCollider.gameObject.GetComponent<Bullet> (); 
		//replace Bullet with projectile later.
		//Is this a shot? // we will need ShotScript 
		/*
		if (shot != null) {
			if (shot.isEnemyShot != isEnemy) {
				TakeDamage (shot.damage);
				//Destroy the shot
				Destroy (shot.gameObject);
			} 	
		}

		if (otherCollider.gameObject.tag == "PlayerUnit" && hp > 0) //Make the tag to 'unit' later 
		{
			print ("I collided with tank");
			gameManager.SendMessage("UnitDamaged", damage, SendMessageOptions.DontRequireReceiver);
		}
		*/
	}	

	void FixedUpdate()
	{
		Vector3 movement = transform.position;
		movement.x += speed;
		transform.position = movement;
		//apply movement to the rigidbody
	}




}
