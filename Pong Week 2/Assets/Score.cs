using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public static int player1score = 0;
	public static int player2score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {
		GUI.Label(new Rect(0,10,Screen.width,100), ""+player1score + "|"+player2score);
	}
}
