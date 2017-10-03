using UnityEngine;
using System.Collections;

public class BirdBaseEvent : MonoBehaviour {

    Animator animatorBirdBase;
    void Start()
    {
        animatorBirdBase = GetComponent<Animator>();
    }

    void swichParit()
    {
        int randomSwich = Random.Range(0, 8);
        animatorBirdBase.SetInteger("randomSwichParit", randomSwich);
    }
}
