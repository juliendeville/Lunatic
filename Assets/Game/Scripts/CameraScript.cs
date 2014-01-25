using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public GameObject Player;
	public float dampTime = 0.3f;

	private GameObject go;  
	private Transform tr;
	private Transform trPlayer;
	private Vector3 posTemp;
	private Vector3 velocity = Vector3.zero;

	void Awake() {
		//mettre en cache les variables
		tr = this.transform;
		if( Player != null ) {
			trPlayer = Player.transform;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( trPlayer != null ) {
			//on bouge pas sur l'axe Z
			posTemp = trPlayer.position;
			posTemp.z = tr.position.z;

			//déplacement fluide de la cam
			tr.position = Vector3.SmoothDamp( tr.position, posTemp, ref velocity, dampTime);
		}
	}
}
