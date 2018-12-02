using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Rigidbody2D rb;

	float speed = 5.0f;
	int health = 5;
    int maxJumps = 1;
    int jumps = 1;
    bool justJumped = false;
	List<Ability> abilities = new List<Ability>();

	// Use this for initialization
	void Start () {
		abilities.Add(new BasicAttack());
	}
	
	// Update is called once per frame
	void Update () {
        print(Input.GetAxis("Vertical") + " / " + jumps + " / " + justJumped);
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        if(Input.GetAxis("Vertical") > 0 && jumps > 0 && justJumped == false) {
            rb.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
            jumps -= 1;
        } else {
            justJumped = false;
        }
        transform.position += move * speed * Time.deltaTime;
		foreach(Ability a in abilities) {
			if(Input.GetKeyDown(a.castKey)) {
				a.activate(transform.position, Input.mousePosition, gameObject);
			}
		}
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        print("Collision");
        if (collision.gameObject.CompareTag("Ground")) {
            jumps = maxJumps;
            justJumped = false;
        }
    }


}
