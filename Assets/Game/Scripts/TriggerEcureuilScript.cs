using UnityEngine;
using System.Collections;

public class TriggerEcureuilScript : MonoBehaviour {
	public GameObject Player;
	public Vector3 destPlayer;
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
		Debug.Log( "TriggerEcureil colli :" + other.tag );
		if( other.tag == "Player" ) {
			ctrlPlayer.emo = Emotion.Colere;
			ctrlPlayer.Move( destPlayer, true );
		}
	}
}
