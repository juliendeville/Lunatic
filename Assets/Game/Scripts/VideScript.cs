using UnityEngine;
using System.Collections;

public class VideScript : EmoBaseScript {
	public GameObject Player;
	public GameObject[] enableItems;
	public GameObject[] disableItems;

	private PlayerScript ctrlPlayer;
	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
		ctrlPlayer = Player.GetComponent<PlayerScript>();
	}

	
	void OnTriggerEnter2D( Collider2D other ) {
		Debug.Log( "Angoisse colli :" + other.tag );
		if( other.tag == "Player" ) {
			ctrlPlayer.emo = Emotion.Angoisse;
			for( int i=0; i< enableItems.Length; i++ ) {
				enableItems[i].SetActive(true);
			}
			for( int i=0; i< disableItems.Length; i++ ) {
				disableItems[i].SetActive(false);
			}
		}
	}

}
