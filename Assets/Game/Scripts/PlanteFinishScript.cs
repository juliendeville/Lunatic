using UnityEngine;
using System.Collections;

public class PlanteFinishScript : EmoBaseScript {
	public GameObject Player;
	public GameObject[] Plateformes;

	private PlayerScript ctrlPlayer;
	private Rigidbody2D riPlayer;
	private Transform trPlayer;
	private bool EffectDone = false;
	private BoxCollider2D[] bcPlateforme;

	private int i = 0;
	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
		trPlayer = Player.transform;
		ctrlPlayer = Player.GetComponent<PlayerScript>();
		riPlayer = Player.GetComponent<Rigidbody2D>();
		bcPlateforme = new BoxCollider2D[Plateformes.Length];
		for( int i=0; i< Plateformes.Length; i++ ) {
			bcPlateforme[i] = Plateformes[i].GetComponent<BoxCollider2D>();
		}
	}

	void Start() {
		go.SetActive( false );
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
		Debug.Log( "done = " + (EffectDone?"true":"false") );
		if( EffectDone ) {
			for( int i=0; i< bcPlateforme.Length; i++ ) {
				bcPlateforme[i].enabled = true;
			}
			riPlayer.WakeUp();
			EffectDone = false;
			return;
		}

		for( int i=0; i< bcPlateforme.Length; i++ ) {
			bcPlateforme[i].enabled = false;
		}

		riPlayer.Sleep();

		EffectDone = true;
		//grimper en haut du haricot
		ctrlPlayer.Move( new Vector2( trPlayer.position.x, tr.position.y + trPlayer.localScale.y/2 + tr.localScale.y/2 ), false );
	}
}
