using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public GameObject txt;
	public bool clic;
	// Use this for initialization
	void Start () {
		txt.SetActive (false);
		Screen.SetResolution (1080,1920,true);
	}
	
	// Update is called once per frame
	void Update () {
		if (clic) {
			txt.SetActive (true);
		} else {
			txt.SetActive (false);
		}
	}

	public void onClickButton(){
		clic = !clic;
	}
}
