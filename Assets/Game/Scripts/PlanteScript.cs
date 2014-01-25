using UnityEngine;
using System.Collections;

public class PlanteScript : MonoBehaviour {
	public GameObject PlanteFinale;


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
		//test émotion euphorie
		if( emo == Emotion.Euphorie ) { 
			
			Debug.Log (":D  " );
			//desactive la petite plante
			PlanteFinale.SetActive( true );
			// active la grande
			go.SetActive( false );
		}
	}
}
