using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Taimeris : MonoBehaviour {

	public Text timerText;
	private float startTime;
	//gaida speles beigas
	static public bool beidzis = false;
	static public int zvLaiks = 0;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (beidzis) {
			return;
		}
		float t = Time.time - startTime;

		//aprekina laiku
		string minutes = ((int)t / 60).ToString ();
		string sekundes = ((int)t % 60).ToString ();
		zvLaiks = Int32.Parse(minutes);

		//izvada taimeri
		timerText.text = "Time - " + minutes + ":" + sekundes;
	}
}
