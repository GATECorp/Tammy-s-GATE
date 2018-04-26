using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Telep2 : MonoBehaviour {

	public Transform player;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("cartedebut"))
		{
			SceneManager.LoadScene("MiniGame");
			Vector3 newpos = player.position;
			player.position = newpos;
		}
	}
}
