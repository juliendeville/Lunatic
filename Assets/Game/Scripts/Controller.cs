using UnityEngine;
using System.Collections;

public enum Emotion {
	Tristesse,
	Colere,
	Euphorie,
	Angoisse
}

public class Controller : MonoBehaviour {
	public Emotion emo;

	private GameObject go;
	private Transform tr;
	private Rigidbody2D rb;
	private Collider2D co;
	private GameObject objet;
	private GameObject oldObjet;
	private bool waitForUp = false;
	private Camera cam2D;

	void Awake() {
		//mettre en cache les variables
		go = this.gameObject;
		tr = this.transform;
		rb = this.rigidbody2D;
		cam2D = GameObject.Find("Cam2D").GetComponent<Camera>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//check touch/click
		bool bIsButtonDown = Input.GetMouseButtonDown(0) || ( Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Began );
		if( waitForUp ) {
			if( Input.GetMouseButtonUp(0) || Input.touchCount == 1 && ( Input.touches[0].phase == TouchPhase.Canceled || Input.touches[0].phase == TouchPhase.Ended ) /*Input.touchCount == 0*/ ){
				bIsButtonDown = false;
				waitForUp = false;
			}
		} else if (bIsButtonDown && iTween.Count() == 0)
		{
			waitForUp = true;
			//position in game
			Vector2 pos = cam2D.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

			//si on touche
			if(hit.collider != null) {
				//les objets qui ont des actions
				if( hit.collider.tag == "Action") {
					objet = hit.collider.gameObject;
					Debug.Log( objet.name );
					Move( new Vector2( objet.transform.position.x, tr.position.y ), true );
				} else { // le reste : décor, zones actives, etc
					objet = null;
					Move( new Vector2( hit.point.x, tr.position.y ), true );
				}
			}
		}
	
   	}

	//fonction qui nous déplace
	public void Move( Vector2 to, bool onlyX ) {
		
		oldObjet = objet;
		if( to.x == tr.position.x && to.y == tr.position.y ){
			EndMove();
		} else {
			/*
			if( iTween.Count() > 0 && oldObjet != null ) {
				GameObject tempObjet = objet;
				objet = oldObjet;
				EndMove();
				objet = tempObjet;
			}
			*/
			Debug.Log ("Target Position: " + to.ToString());
			if( onlyX ) {
				iTween.MoveTo( go, iTween.Hash( "x", to.x, "easing", "linear", "oncomplete", "EndMove" ) );
			} else {
				iTween.MoveTo( go, iTween.Hash( "x", to.x, "y", to.y, "easing", "linear", "oncomplete", "EndMove" ) );
			}
		}
	}

	void OnCollisionEnter2D( Collision2D col ) {
		//on arrete le mouvement si on rencontre un mur
		if( col.collider.tag == "Wall" ){
			iTween.Stop();
			EndMove();
		}
	}

	void EndMove() {
		Debug.Log ("Target arrived " );
		//on envoi l'event qu'on est arrivé au pieds de l'objet à activer, on envoi aussi l'émotion actuelle
		if( objet != null ) {
			objet.SendMessage( "Effect", emo );
		}
	}

}
