using UnityEngine;
using System.Collections;

public class SimpleRotation : MonoBehaviour {

	public float speed = 4F;

	void Start () {
	}

	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * speed);
	}
}
