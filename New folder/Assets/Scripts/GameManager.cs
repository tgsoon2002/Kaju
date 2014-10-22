using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	//Declaring local variables
	public Texture playerHealthTexture; //Player Life
	public float screenPosX; //Controls screen position of texture
	public float screenPosY; //...
	public int iconSizeX = 10; //Controls icon size on screen
	public int iconSizeY = 10; //...
	public int tankHealth = 10; //Starting armor
	public GameObject tank;
	
	void OnGUI()
	{
		//Controls player's health texture
		for (int h = 0; h < tankHealth; h++) 
		{
			GUI.DrawTexture(new Rect(screenPosX + (h * iconSizeX), screenPosY, iconSizeX, iconSizeY), 
			                playerHealthTexture, ScaleMode.ScaleToFit, true, 0);
		}
	}
	
	//Method for taking damage
	void UnitDamaged(int damage)
	{	
		if (tankHealth > 0) 
		{
			tankHealth -= damage;
		}
		
		if(tankHealth <= 0)
		{
			tankHealth = 0;
			//RestartScene();
		}
	}
	
	void RestartScene()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}

