using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vie : MonoBehaviour {

	HealthBar BarreDevie = new HealthBar();
	// Use this for initialization
	void Start () {
		BarreDevie.max = 100;
		BarreDevie.valeur = 100;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) 
	{		
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			BarreDevie.valeur -= 10;
		}

		if (other.gameObject.CompareTag("Pick Up 2")) 
		{
			BarreDevie.valeur += 10;
		}

		if (BarreDevie.valeur == 0)
		{
			SceneManager.LoadScene("Menu");
		}
	}
}
