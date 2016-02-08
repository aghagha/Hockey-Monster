using UnityEngine;
using System.Collections;

public class Mainmenu : MonoBehaviour {

	public string startLevel;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayGame(){
		Application.LoadLevel(startLevel);
	}
}
