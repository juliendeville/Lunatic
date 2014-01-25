using UnityEngine;
using System.Collections;

public class Deplacement : MonoBehaviour {

	public int speed=10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxis ("Horizontal"); 
				
		Vector3 mouvement = new Vector3 (x, 0, 0);
		rigidbody.AddForce (mouvement * speed * Time.deltaTime);
			
				
	
	}
}
