using UnityEngine;
using System.Collections;

public class KaijuHP : MonoBehaviour {

	//***********************************************************************//
	//																	     //
	//																	     //
	//																	     //
	//	Hey Jay, I worked little bit on the Kaiju ,bullet and tanks.         //
	//	I feel little bit tired, so I'll see you tomorrow.  			     //
	//	-Hong  												   		     //
	//																	     //
	//																	     //
	//																	     //
	//																	     //
	//***********************************************************************//
	public int hp =1;
	public bool isEnemy = true;

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
				if (otherCollider.gameObject.tag == "Tank") 
				{

				}

		}
		// Use this for initialization
	//void Start () {
	//
	//}
	
	// Update is called once per frame
//	void Update () {
	//
	//}
}
