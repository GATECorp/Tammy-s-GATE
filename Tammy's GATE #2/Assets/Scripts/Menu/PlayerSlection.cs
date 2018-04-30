using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlection : MonoBehaviour
{

	private string name;
	public Vector3 newPosition;

	public string Name
	{
		get{ return name; }
	}
	
	// Use this for initialization
	void Start ()
	{
		newPosition = transform.position + new Vector3(0, 0, (float) 0.01);
	}
	
	// Update is called once per frame
	void OnMouseOver()
	{
		if (Global.cursor != null)
		{
			Global.cursor.transform.position = newPosition;
			Global.cursor.GetComponent<Renderer>().enabled = true;
		}

		if (Global.Text_Name != null)
		{
			Global.Text_Name.text = name;
		}
	}

	void OnMouseExit()
	{
		if (Global.cursor != null)
		{
			Global.cursor.GetComponent<Renderer>().enabled = false;
		}
		
	}

	void OnMouseDown()
	{
		Global.Text_Name.text = name;
		if (Global.selectedCursor != null)
		{
			Global.selectedCursor.position = newPosition;
			Global.selectedCursor.GetComponent<Renderer>().enabled = true;
		}
	}
}
