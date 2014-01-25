using UnityEngine;
using System.Collections;

public class ArbreScript : MonoBehaviour {
	public Vector3 posFinale;
	public Vector3 rotFinale;
	
	
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

		}
	}
}
