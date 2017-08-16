using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour {

    public float JumpForce;    

    private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        //myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.Y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, JumpForce);
            }		
	}
}
