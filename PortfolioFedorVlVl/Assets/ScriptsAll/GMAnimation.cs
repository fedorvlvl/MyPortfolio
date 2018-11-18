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
		yield return new WaitForSeconds(2.0f);
		GetComponent<Animator>().SetLayerWeight(2,1);
	}
	public void backrndBlackOn ()
	{
		GetComponent<Animator>().SetTrigger("BggrndBlackOn");
	}
	public void backrndBlackOff ()
	{
		GetComponent<Animator>().SetTrigger("BggrndBlackOff");
	}
	public void GMPreviewOn ()
	{
		GetComponent<GM>().SceneInProgect=Lib.ScenesIn.GMPreview;
	}
	public void FedorVlasovOn ()
	{
		GetComponent<GM>().SceneInProgect=Lib.ScenesIn.FedorVlasov;
	}
	public void DemoreelOn ()
	{
		GetComponent<GM>().SceneInProgect=Lib.ScenesIn.Demoreel;
	}
	public void Animations2DOn ()
	{
		GetComponent<GM>().SceneInProgect=Lib.ScenesIn.Animations2D;
	}
	public void Animations3DOn ()
	{
		GetComponent<GM>().SceneInProgect=Lib.ScenesIn.Animations3D;
	}
	public void ModelsOn ()
	{
		GetComponent<GM>().SceneInProgect=Lib.ScenesIn.Models;
	}
	public void BonusGameOn ()
	{
		GetComponent<GM>().SceneInProgect=Lib.ScenesIn.BonusGame;
	}
}
