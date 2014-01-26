using UnityEngine;
using System.Collections;

public class EcureuilScript : EmoBaseScript {
	public GameObject Trigger;
	public GameObject Arbre;
	public GameObject Ecureuil;
	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
	}
	
	
	public override void SetEmo( Emotion emo ) {
		base.SetEmo( emo );
		
		if( emo == Emotion.Tristesse ) {
			//l'ecureuil se cache
			
			AkSoundEngine.PostEvent("EVENT_SFX_Forest_Squirrel_Flee_Play", go );
		} else {
			//ecureuil qui caillasse
			
		}
	}
	
	public override void Effect( ) {
	
	}
}
