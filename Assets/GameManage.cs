using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour {

	public static List<Ability> startingAbilities = new List<Ability>();

	public static List<Ability> currentAbilities = new List<Ability>();

	// Use this for initialization
	void Start () {
		startingAbilities.Add(new BasicAttack());
		startingAbilities.Add(new BasicAttack());
		startingAbilities.Add(new BasicAttack());
		startingAbilities.Add(new BasicAttack());
		currentAbilities= new List<Ability>(startingAbilities);
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
