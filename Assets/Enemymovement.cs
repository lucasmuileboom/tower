using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour 
{
	private Rigidbody _Rigidbody;
	private float velocityX = 0;
	private float velocityZ = 0;
	private float speed = 0;

	void Start () 
	{
		_Rigidbody = GetComponent<Rigidbody> ();
		if(gameObject.name == "enemy(Clone)")
		{
			speed = 3;
		}
		else if(gameObject.name == "enemytank(Clone)")
		{
			speed = 1.5f;
		}
	}
	void Update () 
	{
		_Rigidbody.velocity = new Vector3 (velocityX,0,velocityZ);
	}
	private void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.tag == "up")
		{
			velocityZ = speed;
			velocityX = 0;
		}
		else if(coll.gameObject.tag == "down")
		{
			velocityZ = -speed;
			velocityX = 0;
		}
		else if(coll.gameObject.tag == "left")
		{
			velocityX = -speed;
			velocityZ = 0;
		}
		else if(coll.gameObject.tag == "right")
		{
			velocityX = speed;
			velocityZ = 0;
		}
	}
}
