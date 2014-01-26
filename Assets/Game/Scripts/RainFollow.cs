using UnityEngine;
using System.Collections;

public class RainFollow : MonoBehaviour {

	public Transform Personnage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (Personnage.position.x, Personnage.position.y+10, Personnage.position.z+5);
	
	}
}
