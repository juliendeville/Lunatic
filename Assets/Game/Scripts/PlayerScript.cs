using UnityEngine;
using System.Collections;

public enum Emotion {
	Tristesse,
	Colere,
	Euphorie,
	Angoisse
}

public class PlayerScript : MonoBehaviour {
	public Emotion emo;
	public float speed = 1.0f;

	private GameObject go;
	private Transform tr;
	private Rigidbody2D rb;
	private Collider2D co;
	private GameObject objet;
	private GameObject oldObjet;
	private bool waitForUp = false;
	private Camera cam2D;
	private Vector3 target;

	private bool moving;
	private float lastSqrMag;
	private Vector3 desiredVelocity;

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
	
		//movement
		// check the current sqare magnitude
		float sqrMag = (target - tr.position).sqrMagnitude;
		
		// check this against the lastSqrMag
		// if this is greater than the last,
		// rigidbody has reached target and is now moving past it
		if ( sqrMag > lastSqrMag )
		{
			// rigidbody has reached target and is now moving past it
			// stop the rigidbody by setting the velocity to zero
			desiredVelocity = Vector3.zero;
			moving = false;
			EndMove();
		} 
		
		// make sure you update the lastSqrMag
		lastSqrMag = sqrMag;
   	}

	void FixedUpdate() 
	{
		if ( moving )
			rb.velocity = desiredVelocity;
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
			_Move( to, onlyX );
			/*
			if( onlyX ) {
				iTween.MoveTo( go, iTween.Hash( "x", to.x, "easing", "linear", "oncomplete", "EndMove" ) );
			} else {
				iTween.MoveTo( go, iTween.Hash( "x", to.x, "y", to.y, "easing", "linear", "oncomplete", "EndMove" ) );
			}
			*/
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

	private void _Move( Vector2 to, bool onlyX ) {
		moving = true;
		target = to;
		target.z = tr.position.z;
		if( onlyX ) {
			target.y = tr.position.y;
		}
		desiredVelocity = (target - tr.position).normalized * speed;
		lastSqrMag = Mathf.Infinity;
	}

}
