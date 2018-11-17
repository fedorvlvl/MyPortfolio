using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#region My Unity portfolio 
/*My portfolio
 * This project is Portfolio Fedor Vlasov
 *  Title (Fedor Vlasov, animations, demoreel)
 * 		The Buttons od setting: select Ru or En, music and sound ON/OFF, automatic play (if need) 
 * ----------------------------------------------------------------------------------------------
 * 1. Menu - Fedor Vlasov - open resume
 *           ....................	
 * 2. Menu - aimation - open window menu (2d 3d)
 * Models - lokation whith my models
 *           ....................
 * 3. Menu - demoreel - open sceene whith Cartoon sity (the life streemeng)
 * 2d animations - location when we can camera and aaround it turn on the 2d locations and 2d haracters 
 * 
 */
#endregion

// Drive all my porfolio project (GUI and other part of them)
public class GM : MonoBehaviour {
	[Header ("Current status and datas")]
	[Space]
	public Lib.Language Language;
	public Lib.SoundOnOff Sound;
	public Lib.Automaticplay AutomaticPlay;
	[Space]
	[Header ("Drive stats")]
	public Lib.ScenesIn SceneInProgect;
	[Space]
	[Header ("-----")]
	public GameObject liblModels;
	public GameObject cameraGM;
	private Lib.Language CurrentLanguage;
	private Lib.ScenesIn CurrentScene;


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

	void ScenesF(){
		if (SceneInProgect!=CurrentScene) {			
			SceneLoads();
			CurrentScene = SceneInProgect;
			Debug.Log ("Scene was change, now scene - " + SceneInProgect);
			}
	}
	void SceneLoads(){		
		if ((int)SceneInProgect != 0) {
			SceneManager.LoadScene ((int)SceneInProgect, LoadSceneMode.Additive);
			cameraGM.SetActive(false);
		} else 
			cameraGM.SetActive(true);		
		SceneManager.UnloadScene ((int)CurrentScene);
	}
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CurrentLanguageF();
		ScenesF ();
	}
}

/* notice, idea and other
 зделать рандомные перебивки (птицы и др) которые будут подключать нужные сцены для 2d части.
 найти модель города картоон и найти анимацию ковбоя.
 * */

/* working
 1) thinking about transitions between scenes and decide a qustion with camera___
 2) 
 * */