using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitManager : MonoBehaviour  {
	public List<Tank> unitList = new List<Tank>();
	// Use this for initialization
	void Start () {
		unitList.Add(new Tank());
	}
	
	// Update is called once per frame
	void Update () {
		//DrawUnit ();
	}
	void DrawUnit()
	{
		for (int i = 0; i < unitList.Count; i++) {
			//Graphics.DrawTexture()
				}

	}
}
