using UnityEngine;
using System.Collections;

public class PlayerAnimationScript : MonoBehaviour {
	public GameObject mesh;
	private Animation anim;
	private Rigidbody2D ri;

	// Use this for initialization
	void Start () {
		ri = rigidbody2D;
		anim = mesh.animation;
	}
	
	// Update is called once per frame
	void Update () {
		if (ri.velocity.x > 0.1) {
						//anim droite
						anim.Play ("Marcher");
				} else if (ri.velocity.x < -0.1) {
						//anim gauche
				} else {
						anim.Play("Idle");
				}
	}

	public void Play( string clip ) {
		anim.Play(clip);
	}
}
