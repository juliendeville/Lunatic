using UnityEngine;
using System.Collections;

public class Sound3dScript : MonoBehaviour {
	public string enterEventName;
	public string exitEventName;
	public GameObject soundSource;
	
	public string RTPCName;
	private float RTPCValue;

	private Transform player;

	void Update() {
		if( player != null ) {
			RTPCValue = Vector3.Distance( player.position, transform.position ) / transform.localScale.x * 100;
			AkSoundEngine.SetRTPCValue( RTPCName, RTPCValue, gameObject );
		}
	}
	
	void OnTriggerEnter2D( Collider2D other ) {
		if( other.tag == "Player" ) {
			player = other.transform;
			AkSoundEngine.PostEvent(enterEventName, soundSource );
		}
	}
	
	void OnTriggerExit2D( Collider2D other ) {
		if( other.tag == "Player" ) {
			player = other.transform;
			AkSoundEngine.PostEvent(exitEventName, soundSource );
		}
	}
}
