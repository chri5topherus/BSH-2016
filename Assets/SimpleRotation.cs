using UnityEngine;
using System.Collections;

public class SimpleRotation : MonoBehaviour {

	public float speed = 4F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * speed);
	}
}
