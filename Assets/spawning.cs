using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour 
{
	[SerializeField]
	private GameObject[] enemys;
	private float distance;

	void Start()
	{
		spawn (5,0);
	}
	void spawn(int spawnamount ,int sortofenemy)//spawn hoeveelheid, welken enemy die moet spawnen uit de array
	{
		if(sortofenemy == 0)
		{
			distance = 1;
		}
		else if(sortofenemy == 1)
		{
			distance = 1.5f;
		}
		for(int i = 0; i < spawnamount;i++)
		{
			Instantiate (enemys[sortofenemy], new Vector3(transform.position.x + (i * distance),transform.position.y,transform.position.z), transform.rotation);
		}
	}
}
