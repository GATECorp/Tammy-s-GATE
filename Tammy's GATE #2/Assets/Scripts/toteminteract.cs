using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toteminteract : MonoBehaviour
{

	public Transform player;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("teleporteur"))
			{
				SceneManager.LoadScene("level1");
				Vector3 newpos = player.position;
				player.position = newpos;
			}
	}


}
