using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {


	public float speed = 5f;
	// Use this for initialization
	void Start () {
		 Destroy (gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
		float move = Time.deltaTime * speed;
		transform.position += transform.forward * move;
	}
}
