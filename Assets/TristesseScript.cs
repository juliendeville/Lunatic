using UnityEngine;
using System.Collections;

public class TristesseScript : MonoBehaviour {
	public GameObject Player;
	private Controller ctrlPlayer;
	
	private Transform tr;
	private GameObject go;
	
	void Awake() {
		//mettre en cache les variables
		tr = this.transform;
		go = this.gameObject;
		ctrlPlayer = Player.GetComponent<Controller>();
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
		}
	}
}
