using UnityEngine;
using System.Collections;

public class ChampiScript : EmoBaseScript {
	public GameObject Player;
	private PlayerScript ctrlPlayer;

	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
		ctrlPlayer = Player.GetComponent<PlayerScript>();
	}

	void Start() {
		go.SetActive( false );
	}
	
	
	public override void SetEmo( Emotion emo ) {
		base.SetEmo( emo );
		
		if( emo == Emotion.Colere ) {
			//arbre en feu avec particules
			
		} else {
			//arbre de base
			
		}
	}
	
	public override void Effect( ) {
		//test émotion angoisse
		if( _emo == Emotion.Angoisse ) { 
			ctrlPlayer.emo = Emotion.Euphorie;
		}
	}
/*	
	void OnTriggerEnter2D( Collider2D other ) {
		Debug.Log( "Champi colli :" + other.tag );
	}
	*/
}
