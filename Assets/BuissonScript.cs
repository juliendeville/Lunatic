using UnityEngine;
using System.Collections;

public class BuissonScript : MonoBehaviour {
	private GameObject go;

	// Use this for initialization
	void Start () {
		
		go = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Effect( Emotion emo ) {
		//test émotion euphorie
		if( emo == Emotion.Angoisse ) { 
			AkSoundEngine.PostEvent("EVENT_Fol_Search_Play", go );
		}
	}
}
