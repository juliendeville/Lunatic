using UnityEngine;
using System.Collections;

public class GroundTypeScript : MonoBehaviour {
	public string eventName;
	
	private GameObject go;

	// Use this for initialization
	void Start () {
		go = this.gameObject;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D( Collider2D other ) {
		if( other.tag == "Player" ) {
			AkSoundEngine.PostEvent(eventName, go );
		}
	}
}
