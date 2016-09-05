using UnityEngine;
using System.Collections;

public class FloatingCam : MonoBehaviour {

	private float tChange;
	private float randomX;
	private float randomY;

	float maxX = 6.1F;
	float minX = -6.1F;
	float maxY = 4.2F;
	float minY = -4.2F;

	public float moveSpeed = 0F;

	// Use this for initialization
	void Start () {
		tChange = 0F;
	}
	
	// Update is called once per frame




	void Update () {
		// change to random direction at random intervals
		if (Time.time >= tChange){
			randomX = Random.Range(-1.0F,1.0F); // with float parameters, a random float
			randomY = Random.Range(-1.0F,1.0F); //  between -2.0 and 2.0 is returned
			// set a random interval between 0.5 and 1.5
			tChange = Time.time + Random.Range(0.5F,1.5F);
		}
		transform.Translate(new Vector3(randomX,randomY,0F) * moveSpeed * Time.deltaTime);
		// if object reached any border, revert the appropriate direction
		if (transform.position.x >= maxX || transform.position.x <= minX) {
			randomX = -randomX;
		}
		if (transform.position.y >= maxY || transform.position.y <= minY) {
			randomY = -randomY;
		}
		// make sure the position is inside the borders
		transform.position = new Vector3( Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
		//transform.position.x = Mathf.Clamp(transform.position.x, minX, maxX);
		//transform.position.y = Mathf.Clamp(transform.position.y, minY, maxY);
	}



}
