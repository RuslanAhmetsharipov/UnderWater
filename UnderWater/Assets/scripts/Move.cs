using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed=6f;
	private float side=0f;
	private float forward=0f;
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetAxis ("Vertical") != 0) {
			forward = Input.GetAxis ("Vertical");
			rigidbody.AddForce(forward*transform.forward*speed, ForceMode.Force);
				}
	if (Input.GetAxis ("Horizontal") != 0) {
			side = Input.GetAxis ("Horizontal");
			rigidbody.AddForce(side*transform.right*speed, ForceMode.Force);
				}
	}
}
