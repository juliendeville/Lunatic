using UnityEngine;
using System.Collections;

public class ArbreScript : MonoBehaviour {
	public Vector3 posFinale;
	public Vector3 rotFinale;
	public float duration = 1.0f;
	public GameObject[] enableItems;
	public GameObject[] disableItems;
	
	
	private Transform tr;
	private GameObject go;
	
	void Awake() {
		//mettre en cache les variables
		tr = this.transform;
		go = this.gameObject;
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void Effect( Emotion emo ) {
		//test émotion colère
		if( emo == Emotion.Colere ) { 
			Debug.Log ("arbre killed  " );
			
			for( int i=0; i< enableItems.Length; i++ ) {
				enableItems[i].SetActive(true);
			}
			for( int i=0; i< disableItems.Length; i++ ) {
				disableItems[i].SetActive(false);
			}
			iTween.MoveTo( go, posFinale, duration);
			iTween.RotateTo( go, rotFinale, duration );
		}
	}
}
