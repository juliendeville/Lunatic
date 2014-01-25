using UnityEngine;
using System.Collections;

public class TristesseScript : MonoBehaviour {
	public GameObject[] disableItems;
	public GameObject Player;

	private PlayerScript ctrlPlayer;
	private Transform tr;
	private GameObject go;
	
	void Awake() {
		//mettre en cache les variables
		tr = this.transform;
		go = this.gameObject;
		ctrlPlayer = Player.GetComponent<PlayerScript>();
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
