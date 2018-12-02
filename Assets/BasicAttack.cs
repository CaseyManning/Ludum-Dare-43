using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BasicAttack : Ability{ 

	public BasicAttack(): base(1,1,"space") {

	}

	public override void activate(Vector3 casterPos, Vector3 target, GameObject scene) {
		GameObject b = GameObject.FindGameObjectWithTag("GameController").GetComponent<PrefabManagerScript>().bullet;
		GameObject bullet = Instantiate(b);
		bullet.transform.position = casterPos;
		bullet.transform.LookAt(target);
		bullet.GetComponent<BulletScript>().speed = 10;
	}
}
