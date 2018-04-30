using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Personnage : Character
	{
	
	public enum Charactertype 
	{
		FIRE,
		WATER,
		EARTH,
		AIR
	};


	public Charactertype charactertype;
	private int level;
	public Vector3 position;    
	public float life;





	public Personnage ()
		{
		}

	public void Heal(float life)
	{
		this.life = life;
		isKO = false;
	}

	public bool CanMoveInWater()
	{
		return charactertype == Charactertype.WATER;
	}

	}