using UnityEngine;
using System.Collections;

public class EcureuilScript : EmoBaseScript {
	public GameObject Trigger;
	public GameObject Arbre;
	public GameObject Ecureuil;
	public GameObject Projectile;
	
	public override void Awake() {
		base.Awake();
		//mettre en cache les variables
	}
	
	
	public override void SetEmo( Emotion emo ) {
		base.SetEmo( emo );
		
		if( emo == Emotion.Tristesse ) {
			//l'ecureuil se cache
			
			AkSoundEngine.PostEvent("EVENT_SFX_Forest_Squirrel_Flee_Play", go );
		} else {

			transform.animation.Play("Attack");
			GameObject newProjectile =(GameObject) Instantiate(Projectile,Projectile.transform.position,Quaternion.identity);
			//newProjectile.GetComponentInChildren
			iTween.MoveTo(newProjectile	,Vector3.forward,3);

			//ecureuil qui caillasse
			
		}
	}
	
	public override void Effect( ) {
	
	}
}
