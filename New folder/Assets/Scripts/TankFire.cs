using UnityEngine;
using System.Collections;

public class TankFire : MonoBehaviour {

	public Transform bulletTestPrefab; //projectile prefab for shooting.

	public float shootingRate=0.25f;
	//for cooldown
	private float shootCooldown;
	// Use this for initialization
	void Start () {
		shootCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if ( shootCooldown > 0) 
		{
			shootCooldown-=Time.deltaTime;
		}
	
	}
	//shooting from another script
	public void Attack(bool isEnemy)
	{
		if (CanAttack) 
		{
			shootCooldown = shootingRate;
			//create new shot
			var shotTransfrom = Instantiate (bulletTestPrefab) as Transform;

			//assign position
			shotTransfrom.position= transform.position;

			//the is enemy property
			Bullet shot = shotTransfrom.gameObject.GetComponent<Bullet>();
			if(shot != null)
			{
				shot.isEnemyShot = isEnemy;
			}
			// make the weapon shot always toward it
			MoveScript move=shotTransfrom.gameObject.GetComponent<MoveScript>();
			if(move !=null)
			{
				move.direction=this.transform.right;//towards in 2D space is the right of the sprite
			}
		}
	}
	//is the weapon ready to create a new projectile
	public bool CanAttack 
	{
		get 
		{
			return shootCooldown <= 0f;
		}
	}


}
