using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class target : MonoBehaviour 
{
	private List<GameObject> firstinrange = new List<GameObject>();
	private List<GameObject> strongestinrange = new List<GameObject>();
	private int shootmode = 1;
	public GameObject Target;


	void Update () 
	{
		if(shootmode == 1 && firstinrange.Count > 0 )
		{
			if(Target != firstinrange[0])//first target
			{
				Target = firstinrange[0];
				print (Target);
			}
		}
		else if(shootmode == 2 && firstinrange.Count > 0 )
		{
			if(Target != strongestinrange[0])//strong target
			{
				strongestinrange = firstinrange;
				//strongestinrange = strongestinrange.OrderBy ().ToList ();
				Target = strongestinrange[0];
				print (Target);
			}
		}
	}
	void OnTriggerEnter(Collider coll) 
	{
		if(coll.gameObject.tag == "enemy")
		{
			firstinrange.Add (coll.gameObject);
		}
	}
	void OnTriggerExit(Collider coll) 
	{
		if(coll.gameObject.tag == "enemy")
		{
			firstinrange.Remove (coll.gameObject);
		}
	}
}
