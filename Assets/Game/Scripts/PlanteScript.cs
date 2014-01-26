using UnityEngine;
using System.Collections;

public class PlanteScript : EmoBaseScript {
	public GameObject PlanteFinale;
	public Vector3 scaFinale;
	public float duration = 2.0f;

	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
	}
	
	public void SetEmo( Emotion emo ) {
		base.SetEmo( emo );
		
		if( emo == Emotion.Colere ) {
			//Ronces
			
		} else if( emo == Emotion.Euphorie ) {
			//Lierre fleurie
			
		} else {
			//Lierre
			
		}
	}
	
	public override void Effect( ) {
		//test émotion euphorie
		if( _emo == Emotion.Euphorie ) { 
			
			Debug.Log (":D  " );
			//desactive la petite plante
			iTween.ScaleTo(go,scaFinale,duration);
			PlanteFinale.SetActive( true );
			// active la grande
			go.SetActive( false );
		}
	}
}
