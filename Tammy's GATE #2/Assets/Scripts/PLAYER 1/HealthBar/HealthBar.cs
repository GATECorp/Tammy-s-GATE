using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public static Image Barre;
	public static Text Txt;
	public float max { get; set; }

	public float Life
	{
		get { return Personnage.life; }
		set 
		{
			Personnage.life = Mathf.Clamp( value,0,max);
			Barre.fillAmount = 1 / max * Personnage.life;
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
