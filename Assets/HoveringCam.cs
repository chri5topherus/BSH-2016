using UnityEngine;
using System.Collections;

public class HoveringCam : MonoBehaviour {

	private float xMax; 
	private float yMax; 

	private float xCurrent; 
	private float yCurrent;

	public bool running;

	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		xCurrent = 0F; 
		yCurrent = 0.5F;
		running = false;
		startPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		if (running) 
		transform.localPosition = new Vector3 ( startPosition.x + getX (),  startPosition.y + getY (), startPosition.z); 
	}
		

	float getX() {
		
		xCurrent = xCurrent + 0.002F;
		if(xCurrent == 1F)
			xCurrent = 0F;
		return (Mathf.PerlinNoise(xCurrent, 0.5F) - 0.5F) * 5F;
	}



	float getY() {
		yCurrent = yCurrent + 0.002F;
			if(yCurrent == 1F) 
				yCurrent = 0F;
		return (Mathf.PerlinNoise(0.1F, yCurrent)-0.5F) * 5F;
	}


	public void startHovering() {
		StartCoroutine (startHoveringDelay ());
	}

	public void stopHovering() {
		running = false;
	}

	private IEnumerator startHoveringDelay() {
		yield return new WaitForSeconds (5F);
		running = true;
	}


}
