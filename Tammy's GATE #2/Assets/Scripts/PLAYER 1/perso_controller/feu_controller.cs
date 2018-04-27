using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feu_controller : MonoBehaviour
{

	private Rigidbody rb;
	public float Speed;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * Speed);
	}

}
