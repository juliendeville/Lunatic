using UnityEngine;
using System.Collections;

public class LoadingScript : MonoBehaviour {
	private GameObject go;
	
	void Awake () {
		go = this.gameObject;
		
	}

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad( go );
		Application.LoadLevel("Jeu3");
	}

	
	void OnLevelWasLoaded(int level) {
		Destroy( go );
	}
}
