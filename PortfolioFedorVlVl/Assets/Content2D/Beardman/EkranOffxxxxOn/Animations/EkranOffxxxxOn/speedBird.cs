using UnityEngine;
using System.Collections;

public class speedBird : MonoBehaviour
{
    public float averageSpeedBird=30;
    private Transform birdTransform=null;
    
    private float speedTheBird;

    void Start ()
    {        
        birdTransform = GetComponent<Transform>();
        speedTheBird = Random.Range(averageSpeedBird-2,averageSpeedBird+2);
	}   

	void Update () {
        birdTransform.position += birdTransform.right* speedTheBird * Time.deltaTime;
        
    }
}
