using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{

	public static string currentplayer;
	public static Transform cursor;
	public static Transform selectedCursor;
	public static TextMesh Text_Name;
	
	// Use this for initialization
	 void Awake()
	{
		DontDestroyOnLoad(gameObject);
		
		cursor = GameObject.Find("Cursor").transform;
		selectedCursor = GameObject.Find("Selected_Cursor").transform;
		Text_Name = GameObject.Find("Text_Name").GetComponent<TextMesh>();

		cursor.GetComponent<Renderer>().enabled = false;
		selectedCursor.GetComponent<Renderer>().enabled = false;
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}

public enum ActionType { None, StartGame, GoMenu }
