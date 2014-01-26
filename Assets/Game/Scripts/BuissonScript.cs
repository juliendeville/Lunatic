using UnityEngine;
using System.Collections;

public class BuissonScript : EmoBaseScript {
	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
	}
	
	
	public override void SetEmo( Emotion emo ) {
		base.SetEmo( emo );
		
		if( emo == Emotion.Colere ) {
			//buisson de ronces
			
		} else {
			//buisson feuillu
			
		}
		if( _emo == Emotion.Angoisse ) {
			go.tag = "Action";
		} else {
			go.tag = "Decor";
		}
	}
	
	public override void Effect( ) {
		//test émotion angoisse pour fouiller
		if( _emo == Emotion.Angoisse ) { 
			AkSoundEngine.PostEvent("EVENT_Fol_Search_Play", go );
		}
	}
}
