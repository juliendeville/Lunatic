using UnityEngine;
using System.Collections;

public enum Emotion {
	Tristesse,
	Colere,
	Euphorie,
	Angoisse
}

public class PlayerScript : MonoBehaviour {
	public float speed = 1.0f;
	public GameObject SoundBank;

	private GameObject go;
	private Transform tr;
	private Rigidbody2D rb;
	private Collider2D co;
	private GameObject objet;
	private GameObject oldObjet;
	private bool waitForUp = false;
	private Camera cam2D;

	private Vector3 desiredVelocity;
	private float lastSqrMag;
	private Vector3 target;
	private bool moving;
	
	private Emotion _emo;
	public Emotion emo {
		get {
			return _emo;
		}
		set {
			if( value == Emotion.Angoisse )
				AkSoundEngine.SetState( "ST_Emotions_Set", "ST_Emotions_Anxiety" );
			if( value == Emotion.Colere )
				AkSoundEngine.SetState( "ST_Emotions_Set", "ST_Emotions_Anger" );
			if( value == Emotion.Euphorie )
				AkSoundEngine.SetState( "ST_Emotions_Set", "ST_Emotions_Euphoria" );
			if( value == Emotion.Tristesse )
				AkSoundEngine.SetState( "ST_Emotions_Set", "ST_Emotions_Sadness" );
			_emo = value;
		}
	}

	void Awake() {
		//mettre en cache les variables
		go = this.gameObject;
		tr = this.transform;
		rb = this.rigidbody2D;
		cam2D = GameObject.Find("Cam2D").GetComponent<Camera>();
		//sound init !

	}

	// Use this for initialization
	void Start () {
		
		AkSoundEngine.PostEvent("EVENT_Ambiance_Emotions_Set", go );
		AkSoundEngine.SetSwitch("SW_Fol_Ground_Type","SW_Fol_Ground_Type_Grass", go );
		//footstep
		//AkSoundEngine.PostEvent( "EVENT_Fol_Footstep_Play", go );
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.A ) )
			emo = Emotion.Angoisse;
		if( Input.GetKey(KeyCode.Z ) )
			emo = Emotion.Colere;
		if( Input.GetKey(KeyCode.E ) )
			emo = Emotion.Euphorie;
		if( Input.GetKey(KeyCode.R ) )
			emo = Emotion.Tristesse;
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

		if( moving ) {
			float sqrMag = (target - transform.position).sqrMagnitude;
			if ( sqrMag > lastSqrMag )
			{
				// rigidbody has reached target and is now moving past it
				// stop the rigidbody by setting the velocity to zero
				desiredVelocity = Vector3.zero;
				EndMove();
			} 
			
			// make sure you update the lastSqrMag
			lastSqrMag = sqrMag;
		}

	
   	}

	void FixedUpdate() 
	{
		if( moving ) {
			/*
			float sqrMag = (target - transform.position).sqrMagnitude;
			if ( sqrMag > lastSqrMag )
			{
				// rigidbody has reached target and is now moving past it
				// stop the rigidbody by setting the velocity to zero
				desiredVelocity = Vector3.zero;
				EndMove();
			} 
			
			// make sure you update the lastSqrMag
			lastSqrMag = sqrMag;
			*/
			rb.velocity = desiredVelocity;
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
		if( col.collider.tag == "Wall" ) {
			//iTween.Stop();
			EndMove();
		}
	}

	void EndMove() {
		Debug.Log ("Target arrived " );
		moving = false;
		
		rb.isKinematic = false;
		//on envoi l'event qu'on est arrivé au pieds de l'objet à activer, on envoi aussi l'émotion actuelle
		if( objet != null ) {
			objet.SendMessage( "Effect", emo );
		}
	}

	private void _Move( Vector2 to, bool onlyX ){
		lastSqrMag = Mathf.Infinity;
		moving = true;
		target = to;
		target.z = tr.position.z;
		if( onlyX ) {
			target.y = tr.position.y;
		} else {
			rb.isKinematic = true;
		}
		desiredVelocity = (target - tr.position).normalized * speed;
	}

}
