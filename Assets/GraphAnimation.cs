using UnityEngine;
using System.Collections;

public class GraphAnimation : MonoBehaviour {

	private Vector3 _startPosition;

	void Start () 
	{
		_startPosition = transform.localPosition;
		//Debug.Log (_startPosition);
	}

	void Update()
	{
		transform.localPosition = new Vector3(_startPosition.x, _startPosition.y * Mathf.Cos(Time.time), _startPosition.z);
	}

	// * 
}
