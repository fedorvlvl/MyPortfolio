using UnityEngine;
using System.Collections;

public class birdDrive_01 : MonoBehaviour {

    public GameObject Birdbase;
    public Transform startLeft;
    public Transform endRight;
    public Transform topPosition;
    public Transform downPosition;
    public Animator birdFat;
    public int numberofBirds = 10;
    public Transform parenToThis;


	

   void CreateBirds()
    {        
       for(int i=1; i<numberofBirds ; i++)
          {
            float randPosY = Random.Range(topPosition.transform.position.y, downPosition.transform.position.y);
            GameObject theBird=Instantiate(Birdbase) as GameObject;
            theBird.transform.parent = parenToThis;
            float randScale = Random.Range(0.7f,1.7f);
            theBird.transform.localScale = new Vector3(randScale, randScale, 1.0f);
            theBird.transform.position = new Vector3(startLeft.position.x,randPosY,(i-0.5f));  
                                 
          }
    }

    void birdFatLast()
    {
        birdFat.SetBool("endAnim", true);
    }


}
