using UnityEngine;
using System.Collections;

// 

public class AllSeaFishManagerScript : MonoBehaviour {
	public Transform parentToThis;
	public GameObject[] fishBgg;
	public GameObject[] seaPlant;
	//границы в которых будут тусить рыбы 
	public float maxStartPosTop =0.0f;
	public float maxStartPosLeft =11.0f;
	public float maxStartPosDown =-3.0f;
	public float maxStartPosRight =-11.0f;
    const string nameBigFish = "FishBg_5(Clone)";
    const string fishTagForEat = "FishTag";

    private bool oneBigFishBool;
    private void OneBigFish(out bool oneBigFishBool) //нужна для того чтобы на локации никогда не появлялась вторая большая рыба 
	{
        if (GameObject.Find("FishBg_5(Clone)") != null)
        {
            oneBigFishBool = true;
        }
        else { oneBigFishBool = false; }
	}

    void StartLocPlants() //растения на локацию
	{
		if (parentToThis!=null)
		{
			foreach(GameObject plant in seaPlant)
			{
				GameObject thePlant=Instantiate(plant) as GameObject;
				thePlant.transform.parent=parentToThis;
				plant.transform.position=new Vector3((float)Random.Range(maxStartPosRight,maxStartPosLeft),
				                                     maxStartPosDown-0.25f,
				                                     parentToThis.position.z+2);
			}
		}
	}

	private void StartLocation() // первое появление рыб при старте локации в границах случайным образом
	{

		foreach(GameObject seaEnimal in fishBgg)
		{
			if (Random.Range(0,10)>=4)			// появляетсся рыба или нет (чтобы не повылазили сразу все)
				
				if (parentToThis != null)
			{
				GameObject theFish = Instantiate(seaEnimal) as GameObject; 
				if (theFish.name == nameBigFish)  
				{
                    theFish.SetActive(false); // почемуто невылазит ошибка с тригером если перед дестроем выключить подумать почему. хотя само рождение рыбы както исклюить было б правильней                    
					Destroy(theFish);                    
				}
				else
				{
					theFish.transform.parent=parentToThis;
					theFish.transform.position=new Vector3((float)Random.Range(maxStartPosRight,maxStartPosLeft),
					                                       (float)Random.Range(maxStartPosDown,maxStartPosTop),
					                                       parentToThis.position.z);

					if (theFish.GetComponent<Fishmoove>().ResolutiongoToRight == true)
					{
						if (Random.Range(0,2)==1)
						{
							theFish.transform.localScale=new Vector3(1,1,1);
							
						}
						else
						{
							theFish.transform.localScale=new Vector3(-1,1,1);
							theFish.GetComponent<Fishmoove>().speedSide=-1;
						}
					}
				}
			}
		}
	}
	 
	IEnumerator start() //появление заплывающих в локацию рыб
	{
		int _sos=1;

		while (_sos>=0) //бесконечное рождение рыб
		{           
            float randomTimeStartFish = (float)Random.Range(1, 6);
            yield return new WaitForSeconds(randomTimeStartFish); // рандомные промежутки времени появление рыбы

			if (parentToThis!=null)
			{
                OneBigFish(out oneBigFishBool); // проверяем наличие 5той рыбы
				GameObject fishNewGo = Instantiate (fishBgg[Random.Range(0,fishBgg.Length)]) as GameObject;

                if (oneBigFishBool == true && fishNewGo.name == nameBigFish)
					{ Destroy (fishNewGo);}					
					else {
					fishNewGo.transform.parent=parentToThis;
                    fishNewGo.tag = fishTagForEat;
                    if (Random.Range(0,2)==1) 
						{
							fishNewGo.transform.position=new Vector3(maxStartPosRight,
					                                         (float)Random.Range(maxStartPosDown,maxStartPosTop),
							                                         parentToThis.position.z+1);
							fishNewGo.transform.localScale=new Vector3(-1,1,1);
							fishNewGo.GetComponent<Fishmoove>().speedSide=-1;
						}
						else
						{
							fishNewGo.transform.position=new Vector3(maxStartPosLeft,
					                                         (float)Random.Range(maxStartPosDown,maxStartPosTop),
					                                         parentToThis.position.z-1);
							fishNewGo.transform.localScale=new Vector3(1,1,1);
						}
				        }					
			}
			yield return null;		
		}
	}


	// Use this for initialization
	void Start () 
	{
		StartLocation();
		StartLocPlants();
		StartCoroutine ("start");
	} 
}

