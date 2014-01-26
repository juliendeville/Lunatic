using UnityEngine;
using System.Collections;

public class EmoBaseScript : MonoBehaviour {
	
	
	protected Transform tr;
	protected GameObject go;
	protected Emotion _emo;
	
	public virtual void Awake() {
		//mettre en cache les variables
		tr = this.transform;
		go = this.gameObject;
	}
	
	public virtual void SetEmo( Emotion emo) {
		_emo = emo;
	}
	
	public virtual void Effect() {
	}
}
