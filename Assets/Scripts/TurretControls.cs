using UnityEngine;
using System.Collections;

public class TurretControls : MonoBehaviour {
	public float turretSpeed = 45f;
	public float cannonSpeed = 20f;
	
	public float lowCannonLimit = 315f;
	public float highCannonLimit = 359.9f;
	
	public Transform turretPivot;
	public Transform cannonPivot;
	
	bool firstTime = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnGUI()
	{
		Rect up = new Rect(Screen.width - 100, Screen.height - 150, 50, 50);
		if(GUI.RepeatButton(up, "u")){
			RotateCannon(cannonSpeed);
		}
		
		Rect down = new Rect(Screen.width - 100, Screen.height - 50, 50, 50);
		if(GUI.RepeatButton(down, "d")){
			RotateCannon(-cannonSpeed);
		}
		
		Rect left = new Rect(Screen.width - 150, Screen.height - 100, 50, 50);
		if(GUI.RepeatButton(left, "l")){
			RotateTurret(-turretSpeed);
		}
		
		Rect right = new Rect(Screen.width - 50, Screen.height - 100, 50, 50);
		if(GUI.RepeatButton(right, "r")){
			RotateTurret(turretSpeed);
		}
		
	}
	
	public void RotateTurret(float speed)
	{
		Vector3 rotate = Vector3.up * speed * Time.deltaTime;
		turretPivot.Rotate(rotate);
	}
	
	public void RotateCannon(float speed) {
		if(firstTime)
		{
			cannonPivot.localEulerAngles = new Vector3(359,0,0);
			firstTime = false;
		}
	 
		float rotate = speed * Time.deltaTime;
		Vector3 euler = cannonPivot.localEulerAngles;
		
		euler.x = Mathf.Clamp(euler.x - rotate, lowCannonLimit, highCannonLimit);
		
		cannonPivot.localEulerAngles = euler;
	}
}
