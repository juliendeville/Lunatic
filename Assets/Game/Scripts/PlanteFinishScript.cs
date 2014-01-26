using UnityEngine;
using System.Collections;

public class PlanteFinishScript : EmoBaseScript {
	public GameObject Player;
<<<<<<< HEAD
	public GameObject Plateforme;
	
	public Vector3 scaFinale;
	public float duration = 2.0f;
=======
	public GameObject[] Plateformes;
>>>>>>> d32e14e7c3b8a9c6df473ea9e3ce66bd2db839ea

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
		iTween.ScaleTo(go,scaFinale,duration);
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
