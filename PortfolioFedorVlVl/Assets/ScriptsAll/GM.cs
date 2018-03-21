using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#region My Unity portfolio 
/*My portfolio
 * This project is Portfolio Fedor Vlasov
 * 1. Title (select Ru or En, music and sound ON/OFF, automatic play)
 * --------------------------------------------------
 * 2. Menu (models, animations, VFX Unity, codes, resume, contacts )
 *           ....................
 *    1) Title - animation (4-5 s)  
 *    2) models (start camera fly accros area with my models
 *               if we want we can drow camera and come to models
 *               what we like to see better)
 *    3) animation (select 2d, GUI animation, or 3d) after that we 
 *                  have opporunity to select models and use from
 *                  list of animations it.               
 *    4) vfx - effects particles and other
 *    5) codes change items for Hillary
 *    6) resume
 *    7) contacts  
 * */
#endregion

// Drive all my porfolio project (GUI and other part of them)
public class GM : MonoBehaviour {
	[Header ("Current status and datas")]
	[Space]
	public Lib.Language Language;
	public Lib.SoundOnOff Sound;
	public Lib.Automaticplay AutomaticPlay;
	public Lib.Scenes Scene;
	[Space]
	[Header ("----")]
	private Lib.Language CurrentLanguage;
	private Lib.Scenes CurrentScene;

	#region CurrentLanguage
	void CurrentLanguageF()	{
		if (CurrentLanguage!=Language) {
			CurrentLanguage = Language;
			switch (Language) {
			case Lib.Language.En: CurrentLanguageEn(); break;
			case Lib.Language.Ru: CurrentLanguageRu (); break;
			default: CurrentLanguageEn (); break;
			}
		}
	}
	void CurrentLanguageEn(){
		CurrentLanguageLog ();
	}
	void CurrentLanguageRu(){
		CurrentLanguageLog ();
	}
	void CurrentLanguageLog(){
		Debug.Log ("Language was change, now " + Language);
	}
	#endregion

	#region Sound
	#endregion

	#region AutomaticPlay
	#endregion

	#region CurrentScene
	void SceneF(){
		if (Scene!=CurrentScene) {
			CurrentScene = Scene;
			SceneLoads();
			}
	}
	void SceneLoads(){
		CurrentSceneLog ();
	}
	void CurrentSceneLog(){
		Debug.Log ("Scene was change, now " + CurrentScene);
	}
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CurrentLanguageF();
		SceneF ();
	}
}

/* notice, idea and other
 зделать рандомные перебивки (птицы и др) которые будут подключать нужные сцены
 * */

/* working
 1) GUI
 2)  
 * */