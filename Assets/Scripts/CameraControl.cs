using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CameraControl : MonoBehaviour
{
	[SerializeField]
	[Range(0.0f, 25.0f)]
	private float moveSpeed = 5.0f;

	[SerializeField]
	[Range(0.0f, 10.0f)]
	private float rotateSpeed = 2.5f;

	[SerializeField]
	private Transform child;

	private Vector3 moveVector = Vector3.zero;
	private Vector2 rotateVector = Vector2.zero;

	private Vector3 lastMousePos = Vector3.zero;

	private new Rigidbody rigidbody;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();

		if (child == null)
			Debug.LogError("No child rigidbody was assigned!", gameObject);

		lastMousePos = Input.mousePosition;

		Cursor.lockState = CursorLockMode.Locked;
	}

	private void Update()
	{
		moveVector = transform.forward * Input.GetAxis("Vertical");
		moveVector += transform.right * Input.GetAxis("Horizontal");
		moveVector += transform.up * Input.GetAxis("Applicate");

		rotateVector = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) 
			* rotateSpeed;

		lastMousePos = Input.mousePosition;
	}

	private void FixedUpdate()
	{
		rigidbody.velocity = moveVector * moveSpeed;
		transform.Rotate(0.0f, rotateVector.x, 0.0f);
		child.Rotate(-rotateVector.y, 0.0f, 0.0f);
	}
}
