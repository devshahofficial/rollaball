// This script is licensed under the MIT License.
// Copyright (c) [Dev Shah] [2023]

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PLayerController : MonoBehaviour
{
	public float speed = 0;

	private Rigidbody rb;
	private float movementX;
	private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    	void OnMove(InputValue movementValue)
    {
	Vector2 movementVector = movementValue.Get<Vector2>();
	movementX = movementVector.x;
	movementY = movementVector.y;

    }

	void FixedUpdate()
	{
		Vector3 movement = new Vector3(movementX, 0.0f, movementY);
		rb.AddForce(movement * speed);
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("PickUp"))
		{other.gameObject.SetActive(false);}
	}

}



