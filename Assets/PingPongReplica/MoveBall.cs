using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    #region Variables
		Vector3 ballStartPosition;
		Rigidbody2D rb;
		float speed = 400;
		public AudioSource blip;
		public AudioSource blop;
    #endregion

    // Use this for initialization
    void Start()
	{
		rb = this.GetComponent<Rigidbody2D>();
		ballStartPosition = this.transform.position;
		ResetBall();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "backwall")
			blop.Play();
		else
			blip.Play();
	}

	public void ResetBall()
	{
		this.transform.position = ballStartPosition;
		rb.velocity = Vector3.zero;
		Vector3 dir = new Vector3(Random.Range(100, 300), Random.Range(-100, 100), 0).normalized;
		rb.AddForce(dir * speed);
	}

	void Update()
	{
		// there is some unwanted behaviour to reset position ..
		if (Input.GetKeyDown("space"))
		{
			ResetBall();
		}
	}
}
