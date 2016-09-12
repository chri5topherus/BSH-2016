using UnityEngine;
using System.Collections;

public class MoveUpDownPlatform : MonoBehaviour {
	
	private Vector3 _startPosition;

	// Use this for initialization
	void Start () {
		_startPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3(_startPosition.x, _startPosition.y * Mathf.Cos(Time.time/4F) / 4F, _startPosition.z);
	}
}
