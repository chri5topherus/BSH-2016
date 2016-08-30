using UnityEngine;
using System.Collections;

public class DisplayScript : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{


		//Debug.Log ("displays connected: " + Display.displays.Length);
		// Display.displays[0] is the primary, default display and is always ON.
		// Check if additional displays are available and activate each.

		//Screen.SetResolution(2560, 1440, true);

		//Screen.SetResolution(1280, 720, false);
		//Screen.fullScreen =true;

		if (Display.displays.Length > 1) {
			Display.displays [1].Activate ();
			//Display.displays[1].SetRenderingResolution(1920, 1200);
			//Display.displays [1].SetParams (1920, 1200, 0, 0);
		}
		if (Display.displays.Length > 2) {
			Display.displays [2].Activate ();
		}
	}




	// Update is called once per frame
	void Update()
	{

	}
}
