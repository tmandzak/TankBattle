﻿using UnityEngine;
using System.Collections;

public class ChassisControls : MonoBehaviour {

	public CharacterController characterControl;
	public float moveSpeed = 10f;
	public float rotateSpeed = 45f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnGUI()
	{
		Rect fore = new Rect(50, Screen.height - 150, 50, 50);
		if(GUI.RepeatButton(fore, "f")){
			MoveTank(moveSpeed);
		}
		
		Rect back = new Rect(50, Screen.height - 50, 50, 50);
		if(GUI.RepeatButton(back, "b")){
			MoveTank(-moveSpeed);
		}
		
		Rect left = new Rect(0, Screen.height - 100, 50, 50);
		if(GUI.RepeatButton(left, "l")){
			RotateTank(-rotateSpeed);
		}

		Rect right = new Rect(100, Screen.height - 100, 50, 50);
		if(GUI.RepeatButton(right, "r")){
			RotateTank(rotateSpeed);
		}
	}
	
	public void MoveTank(float speed)
	{
		Vector3 move = characterControl.transform.forward*speed*Time.deltaTime;
		move.y -= 9.8f*Time.deltaTime;
		characterControl.Move(move);
	}
	
	public void RotateTank(float speed)
	{
		Vector3 rotate = Vector3.up * speed * Time.deltaTime;
		characterControl.transform.Rotate(rotate);
	
	
	}
}
