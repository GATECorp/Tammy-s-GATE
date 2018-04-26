using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	static Image Barre;
	static Text Txt;
	public float max { get; set; }

	private float Valeur;
	public float valeur
	{
		get {return Valeur;}
		set 
		{
			Valeur = Mathf.Clamp( value,0,max);
			Barre.fillAmount = 1 / max * Valeur;
			Txt.text = Barre.fillAmount * 100 + "%";
		}
	}

	// Use this for initialization
	void Start () {
		Barre = GetComponent<Image>();
		Txt = transform.Find ("Text").GetComponent<Text> ();
	}
	
	// Update is called once per frame

}
