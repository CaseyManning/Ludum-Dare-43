using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	float speed = 5.0f;
	int health = 5;
	List<Ability> abilities = new List<Ability>();

	// Use this for initialization
	void Start () {
		abilities.Add(new BasicAttack());
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
     	transform.position += move * speed * Time.deltaTime;
		foreach(Ability a in abilities) {
			if(Input.GetKeyDown(a.castKey) && a.currentCooldown < 0) {
				a.activate(transform.position, new Vector3 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0), gameObject);
				a.currentCooldown = a.cooldown;
			}
			a.currentCooldown -= Time.deltaTime;
		}
	}
}
