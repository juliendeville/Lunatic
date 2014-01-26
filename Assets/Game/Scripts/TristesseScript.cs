using UnityEngine;
using System.Collections;

public class TristesseScript : EmoBaseScript {
	public GameObject[] disableItems;
	public GameObject Player;

	private PlayerScript ctrlPlayer;
	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
		ctrlPlayer = Player.GetComponent<PlayerScript>();
	}
	
	void OnTriggerEnter2D( Collider2D other ) {
		Debug.Log( "Tristesse colli :" + other.tag );
		if( other.tag == "Player" ) {
			ctrlPlayer.emo = Emotion.Tristesse;
			for( int i=0; i< disableItems.Length; i++ ) {
				disableItems[i].SetActive(false);
			}
		}
	}
}
