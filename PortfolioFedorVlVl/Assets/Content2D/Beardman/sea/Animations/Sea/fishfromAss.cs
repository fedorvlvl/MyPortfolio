using UnityEngine;
using System.Collections;

public class fishfromAss : MonoBehaviour {
	public GameObject[] fishFromAss; 
	GameObject parentAllFish;
	public GameObject papaFish;
	Animation anim;
	public Transform startfromThis;


	
	void firstGo() //рождение рыб из задницы
    {
		GameObject f1 = Instantiate(fishFromAss[Random.Range(0,fishFromAss.Length)]) as GameObject;
		
		if (parentAllFish!=null)
		{
			f1.transform.parent=parentAllFish.transform;
		}
		f1.transform.position=startfromThis.position;


		if (papaFish.GetComponent<Fishmoove>().speedSide==(-1)) // движение в противоположную сторону от родительской рыбы
		    {
				f1.transform.localScale=new Vector3(1,1,1);
				f1.GetComponent<Fishmoove>().speedSide=1;
			}
			else 
				{
					f1.transform.localScale=new Vector3(-1,1,1);
					f1.GetComponent<Fishmoove>().speedSide=-1;
				}		
	}
	


	void playidlebigFish() // клип - событие с анимацией - жреттт
	{
		anim.Play("IdleBiFish");
	}

	private GameObject edaFish;
	void OnTriggerEnter(Collider other) 
	{
        if (other.CompareTag("FishTag"))
        {
            anim.Play("breakfast");
            edaFish = other.gameObject;
        }
	}
	void EatNow()
	{
		if (edaFish!=null)
        { Destroy(edaFish); }		
	}
 
	// Use this for initialization
	void Start ()
    {
        parentAllFish = GameObject.Find("AllSeaFishManager");
        anim = gameObject.GetComponent<Animation>();
	}
}
