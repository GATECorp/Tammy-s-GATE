using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{

	public ActionType type;
	
	// Use this for initialization
	private void Update()
	{
		if (transform.GetComponent<Renderer>() != null)
		{
			if (Global.currentplayer != null)
			{
				transform.GetComponent<Renderer>().enabled = true;
			}
			else
			{
				transform.GetComponent<Renderer>().enabled = false;
			}
		}
		
	}

	void OnMouseDown()
	{
		switch (type)
		{
				case ActionType.StartGame:
					Application.LoadLevel("MiniGame");
					break;
				case ActionType.GoMenu:
					Application.LoadLevel("Menu");
					break;
		}
	}
	
	
}
