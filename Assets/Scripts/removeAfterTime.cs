using UnityEngine;
using System.Collections;

public class removeAfterTime : MonoBehaviour {
	public float waitTime;
	// Use this for initialization
	void Start () {
	
	}
	
	
	// Update is called once per frame
	void Update () {
		waitTime -= Time.deltaTime;
		if(waitTime <= 0)
			Destroy(gameObject);
		
	}
}