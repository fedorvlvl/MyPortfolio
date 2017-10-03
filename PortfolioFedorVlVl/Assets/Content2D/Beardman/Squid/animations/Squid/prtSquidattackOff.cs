using UnityEngine;
using System.Collections;

public class prtSquidattackOff : MonoBehaviour {

	//  скрипты prtSquidattackOff и AttackPrtSquidOn делал для себя чтобы видеть как работает 

	IEnumerator PrtOffxxx5sec()
	{
		yield return new WaitForSeconds(5.5f);
		gameObject.SetActive(false);
	}

	// Use this for initialization
	void Update () {
		StartCoroutine(PrtOffxxx5sec()); 
	}
}
