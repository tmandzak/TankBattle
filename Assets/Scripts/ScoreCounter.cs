using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	public static int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnGUI()
	{
		Rect scoreRect = new Rect(0,0,100,30);
		GUI.Box(scoreRect, "" + score);
	
	
	}
	
	
}
