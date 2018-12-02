using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability: MonoBehaviour {

	public float cooldown;
	public float manaCost;

	public string castKey;
	public abstract void activate(Vector3 casterPos, Vector3 target, GameObject scene);

	public Ability(float cooldown, float cost, string key) {
		this.cooldown = cooldown;
		this.manaCost = cost;
		this.castKey = key;
	}
	
}
