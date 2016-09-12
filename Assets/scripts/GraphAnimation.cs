using UnityEngine;
using System.Collections;

public class GraphAnimation : MonoBehaviour {

	private Vector3 _startPosition;
	private float randomNumber; 


	void Start () 
	{
		_startPosition = transform.localPosition;
		randomNumber = Random.Range (-100, 100) / 100F;
		//Debug.Log (_startPosition);
	}

	void Update()
	{
		transform.localPosition = new Vector3(_startPosition.x, _startPosition.y * Mathf.Cos(Time.time/2F + randomNumber), _startPosition.z);
	}

	// * 
}
