﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponentInChildren<Text>().text = PlayerScript.abilities[ButtonScript.buttonAbilities[gameObject.tag]].abilityName;
	}
}