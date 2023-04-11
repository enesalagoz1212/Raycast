using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

	RaycastHit hit;
	public LayerMask enemy;

	void Start()
	{

	}


	void Update()
	{

		if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out hit,Mathf.Infinity,enemy))
		{
			Debug.Log(hit.collider.name);
			Debug.DrawRay(this.transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
			Debug.Log(hit.distance);
		}


	}
}
