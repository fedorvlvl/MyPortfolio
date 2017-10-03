using UnityEngine;
using System.Collections;

public class FishDestruction : MonoBehaviour 
{
	float findBorderR=0;
	float findBorderL=0;
	float findBorderT=0;
	float findBorderD=0;
	// Use this for initialization
	void Start () {
		if (GameObject.Find("AllSeaFishManager")!=null)
		{
            findBorderR = GameObject.Find("AllSeaFishManager").GetComponent<AllSeaFishManagerScript>().maxStartPosRight;
            findBorderL = GameObject.Find("AllSeaFishManager").GetComponent<AllSeaFishManagerScript>().maxStartPosLeft;
            findBorderT = GameObject.Find("AllSeaFishManager").GetComponent<AllSeaFishManagerScript>().maxStartPosTop;
            findBorderD = GameObject.Find("AllSeaFishManager").GetComponent<AllSeaFishManagerScript>().maxStartPosDown;
		}
	}
	
	// Update is called once per frame
	void Update () 
    {
		if ( gameObject.transform.position.x < findBorderR
		    					||
		    gameObject.transform.position.x > findBorderL
		    					||
		    gameObject.transform.position.y> findBorderT
		    					||
		    gameObject.transform.position.y<findBorderD )
		{
			Destroy(gameObject);
		}
	}
}
