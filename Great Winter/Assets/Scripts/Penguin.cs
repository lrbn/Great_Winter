using UnityEngine;
using System.Collections;

public class Penguin : MonoBehaviour {

	private float speed;
	private Vector3 position;
	private Vector3 scale;
	private Animator animator;

	void Awake() {

		animator = this.GetComponent<Animator> ();
		speed = 1 * Time.deltaTime;

	}
		
	void Update () {

		penguinMovement ();

	}

	public void penguinMovement() {

		if (Input.GetKey("a") || Input.GetKey("left")) {
			animator.SetInteger ("Direction", 1);
			position = this.transform.parent.position;
			scale = this.transform.parent.localScale;

			position.x -= speed;
			this.transform.parent.position = position;

			scale.x = -1;
			this.transform.parent.localScale = scale;

		} else if (Input.GetKey("d") || Input.GetKey("right")) {
			animator.SetInteger ("Direction", 1);
			position = this.transform.parent.position;
			scale = this.transform.parent.localScale;

			position.x += speed;
			this.transform.parent.position = position;

			scale.x = 1;
			this.transform.parent.localScale = scale;

		} else {
			animator.SetInteger ("Direction", 0);
		}

		// TODO Find a way to implement this...
		// Jump
//		if (Input.GetKey("w") || Input.GetKey("up")) {
//
//			position.y += speed;
////			this.transform.parent.position = position;
//			this.transform.position = position;
//
//		}

//		if (Input.GetKey("space")) {} Space attack
//		if (Input.GetKey("x") || Input.GetKey("m")) {} X or M to shield


	}
}
