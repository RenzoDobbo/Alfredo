using UnityEngine;
using System;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(pos);

    }

    void OnMouseDown()
    {

        this.transform.position = Input.mousePosition;
        Debug.Log("2134");

    }

}
