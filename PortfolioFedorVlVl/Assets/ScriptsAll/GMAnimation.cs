using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMAnimation : MonoBehaviour {	
	// Use this for initialization
	void Start () {		
		StartCoroutine("StartPortf");
	}
	IEnumerator StartPortf ()
	{
		yield return new WaitForSeconds(3.0f);
		GetComponent<Animator>().SetLayerWeight(2,1);
	}
}
