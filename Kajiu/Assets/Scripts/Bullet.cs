using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{

	public int damage =1;// Use this for initialization
	public bool isEnemyShot = false;
	void Start () 
	{
		DestroyObject (gameObject, 20);//20sec, need to destory to avoid leak
	}
	
	// Update is called once per frame
	//void Update () {
	//
	//}
}
