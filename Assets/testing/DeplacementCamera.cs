using UnityEngine;
using System.Collections;

public class DeplacementCamera : MonoBehaviour {

	public Transform target;
	public int decalageX=5;
	public int decalageY=20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = new Vector3(target.position.x+decalageX,target.position.y,target.position.z-decalageY);
	}
}
