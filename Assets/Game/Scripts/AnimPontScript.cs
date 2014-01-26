using UnityEngine;
using System.Collections;

public class AnimPontScript : MonoBehaviour {
	public GameObject pont;

	private Animator anPont;


	
	void Awake() {
		//mettre en cache les variables
		anPont = pont.GetComponent<Animator>();
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D( Collider2D other ) {
		Debug.Log( "Angoisse colli :" + other.tag );
		if( other.tag == "Player" ) {
			anPont.SetTrigger( "Crash" );
		}
	}

}
