using UnityEngine;
using System.Collections;

public class PlanteFinishScript : MonoBehaviour {
	public GameObject Player;
	public GameObject Plateforme;

	private Transform tr;
	private GameObject go;
	private Controller ctrlPlayer;
	private Transform trPlayer;
	private bool EffectDone = false;
	private BoxCollider2D bcPlateforme;

	private int i = 0;
	
	void Awake() {
		//mettre en cache les variables
		tr = this.transform;
		go = this.gameObject;
		trPlayer = Player.transform;
		ctrlPlayer = Player.GetComponent<Controller>();
		bcPlateforme = Plateforme.GetComponent<BoxCollider2D>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void Effect( Emotion emo ) {
		Debug.Log( "done = " + (EffectDone?"true":"false") );
		if( EffectDone ) {
			bcPlateforme.enabled = true;
			EffectDone = false;
			return;
		}
		bcPlateforme.enabled = false;
		EffectDone = true;
		//grimper en haut du haricot
		ctrlPlayer.Move( new Vector2( trPlayer.position.x, tr.position.y + trPlayer.localScale.y/2 + tr.localScale.y/2 ), false );
	}
}
