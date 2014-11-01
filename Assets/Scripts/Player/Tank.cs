using UnityEngine;
using System.Collections;

[System.Serializable]
public class Tank  {

	public int tankId;
	public int tankHP;
	public Texture2D TankIcon;
	public int tankPower;
	public float tankFireRate;
	public int tankMoveSpeed;
	public Vector2 tankPosition;
	
	public Tank(Vector2 pos)
	{
		tankId = 0;
		tankHP = 10;
		TankIcon = Resources.Load<Texture2D>("Icon/Tank");
		tankPosition = pos;
	}
	public Tank ()
	{

	}

}
