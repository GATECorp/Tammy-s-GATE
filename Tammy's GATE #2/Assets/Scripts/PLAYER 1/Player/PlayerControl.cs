using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerControl : MonoBehaviour
{

	public Transform[] playerList;
	public Transform currentPlayer;
	
	// Use this for initialization
	void Start ()
	{
		
		if (Global.currentplayer != null)
		{
			currentPlayer = playerList.Single(d => d.name == Global.currentplayer);
			if (currentPlayer == null)
			{
				Application.LoadLevel("Menu");
			}

			//InstantiatePlayer();
			if (currentPlayer != null)
			{
				currentPlayer = Instantiate(currentPlayer, transform.position, currentPlayer.rotation) as Transform;
				currentPlayer.parent = transform;
				Debug.Log("Player's Parent: " + currentPlayer.transform.parent.name);
			}
		}
		else
		{
			Application.LoadLevel("Menu");
		}
	}

	/*void InstantiatePlayer()
	{
		if (currentPlayer != null)
		{
			currentPlayer = Instantiate(currentPlayer, n, currentPlayer.rotation) as Transform;
			currentPlayer.parent = transform;
		}
	}*/
}
