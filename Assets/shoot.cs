using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour 
{
	private target target;
	void Start () 
	{
		target = GetComponent<target> ();
	}
	

	void Update () 
	{
		//target.inrange[0]
		//transform.LookAt(new Vector3(point.x, transform.position.y, point.z));//targeted enemy
	}
	void Shoot()
	{
		//Instantiate(projectile, transform.position,transform.rotation)
	}
}
