using UnityEngine;
using System.Collections;

public class ArbreScript : EmoBaseScript {
	public Vector3 posFinale;
	public Vector3 rotFinale;
	public Vector3 scaFinale;
	public float duration = 1.0f;
	public GameObject[] enableItems;
	public GameObject[] disableItems;
	public GameObject player;

	private bool done = false;

	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables




	}

	void Start(){
		
			iTween.MoveTo (go, posFinale, duration);
			iTween.RotateTo (go, rotFinale, duration);
			iTween.ScaleTo( go, scaFinale, duration );
	}

	
	public override void SetEmo( Emotion emo ) {
		base.SetEmo( emo );

		if( emo == Emotion.Colere ) {
			//arbre en feu avec particules

		} else {
			//arbre de base

		}
		
		if( _emo == Emotion.Colere ) {
			go.tag = "Action";
		} else {
			go.tag = "Decor";
		}
	}
	
	public override void Effect( ) {
		//test émotion colère
		if( _emo == Emotion.Colere ) { 
			done = true;
			Debug.Log ("arbre killed  " );

			player.GetComponent<PlayerAnimationScript>().Play("Attack");

			for( int i=0; i< enableItems.Length; i++ ) {
				enableItems[i].SetActive(true);
			}
			for( int i=0; i< disableItems.Length; i++ ) {
				disableItems[i].SetActive(false);
			}
			//remplacer par anim arbre kill ?
			iTween.MoveTo( go, posFinale, duration);
			iTween.RotateTo( go, rotFinale, duration );
			iTween.ScaleTo( go, scaFinale, duration );
		}
	}
}
