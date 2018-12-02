using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	public static Dictionary<string,int> buttonAbilities = new Dictionary<string, int>();
	void Start () {
		List<Ability> currentAbilities = new List<Ability>(GameManage.currentAbilities);
		for(int i = 0; i < 4; i++) {
			if(currentAbilities.Count == 0) {
				Debug.LogError("aaaah no abilities");
				return;
			}
			int x = Random.Range(0,currentAbilities.Count);
			buttonAbilities["button" + (i+1)] = x;
			currentAbilities.Remove(currentAbilities[x]);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(buttonAbilities.Keys.Count);
	}

	public void buttonPress(GameObject button) {
		Debug.Log(button.tag);
		Debug.Log("removing ability " + buttonAbilities[button.tag]);
		GameManage.currentAbilities.RemoveAt(buttonAbilities[button.tag]);
		Debug.Log(button.tag);
		SceneManager.LoadScene(0);
	}
}
