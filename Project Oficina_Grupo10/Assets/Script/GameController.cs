using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject cone;
    private bool couldInstantiate;

	// Use this for initialization
	void Start () {
        couldInstantiate = true;
	}
	
	// Update is called once per frame
	void Update () {
        if((int)Time.time % 3 == 0)
        {
            if(couldInstantiate)
            {
                Instantiate(cone, new Vector3(8, -1.1f, 0), Quaternion.identity);
                couldInstantiate = false;
            }
        }
        else
        {
            couldInstantiate = true;
        }
        
	}
}
