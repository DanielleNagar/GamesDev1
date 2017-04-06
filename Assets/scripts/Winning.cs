using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Winning : MonoBehaviour {

	public int score;
	public int win=10;
	private string tot;
	private Text scriptText; 
	private Text timeText;
	public GameObject timeObject;
	public GameObject scoreObject;
	private float totTime;
	//Component ts;
	void Start () {
		
		score = 0;
		//GameObject obj= GameObject.Find ("Score");
		//Debug.Log (obj == null);
		scriptText = scoreObject.GetComponent<Text>();
		timeText = timeObject.GetComponent<Text> ();//.GetComponent(Text);
		setCountText ();
		tot = win.ToString ();
	}
	public void Kill(){
		score++;
		setCountText ();
		if (score >= 10) {
			scriptText.text ="WIN";

		}

	}
	void Update(){
		totTime += Time.deltaTime;
		timeText.text = "TIME: " + Math.Round(totTime).ToString();
		//Debug.Log (Time.deltaTime);
		//Mathf.

	}
	void setCountText(){
		//string scores = score.ToString ();
		//tot = win.ToString ();
		String kill = "KILL: " + score.ToString () +"/"+ win.ToString ();
		Debug.Log (kill);
		scriptText.text = kill;
		// change the text in the UI script Text
	}

}
