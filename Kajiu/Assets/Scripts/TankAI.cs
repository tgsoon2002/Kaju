using UnityEngine;
using System.Collections;

public class TankAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//shooting
		bool shoot = true;
		if (shoot) 
		{
			TankFire weapon = GetComponent<TankFire> ();
			if (weapon != null) 
			{	
				weapon.Attack (false);
			}
		}
	}

}
