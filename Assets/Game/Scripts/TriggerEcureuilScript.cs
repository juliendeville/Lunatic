using UnityEngine;
using System.Collections;

public class TriggerEcureuilScript : EmoBaseScript {
	public GameObject Player;
	public Vector3 destPlayer;
	private PlayerScript ctrlPlayer;

	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
		ctrlPlayer = Player.GetComponent<PlayerScript>();
	}
	
	void OnTriggerEnter2D( Collider2D other ) {
		Debug.Log( "TriggerEcureil colli :" + other.tag );
		if( other.tag == "Player" ) {
			ctrlPlayer.emo = Emotion.Colere;
			ctrlPlayer.Move( destPlayer, true );
		}
	}
}
