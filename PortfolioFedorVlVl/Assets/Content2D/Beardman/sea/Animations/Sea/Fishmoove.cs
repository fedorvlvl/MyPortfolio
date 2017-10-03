using UnityEngine;
using System.Collections;

public class Fishmoove : MonoBehaviour 
{
	public float speed=0.5f;
	public bool ResolutiongoToRight=true;
	public float speedSide =1;
	// Use this for initialization
	float speedWork =0;


	void Start () 
	{
		speedWork=(speed +(float)Random.Range(1,3)/4);
		switch (gameObject.name)
		{
		case "FishBg_3(Clone)": speedSide=1; gameObject.transform.localScale=new Vector3(1,1,1); speed=0.25f; break;
		case "FishBg_7(Clone)": gameObject.transform.localScale=new Vector3(1,1,1);speed=0.2f; break;
		case "Smalfish_4_1(Clone)": speedWork=speed*4; break;
		case "Smalfish_4_2(Clone)": speedWork=speed*4; break;
		case "Smalfish_4_3(Clone)": speedWork=speed*4; break;
		case "Smalfish_4_4(Clone)": speedWork=speed*4; break;
		default: break;
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position+=transform.right * speedWork *Time.deltaTime*(-1)*speedSide;
	}
}
