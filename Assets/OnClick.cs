using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

    public float speed = 1000;
    Vector3 v3 = new Vector3();

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        var braulio = GameObject.Find("Braulio");        

        if (Input.GetMouseButtonDown(0)) {

            v3 = Input.mousePosition;
            v3.z = 1;
            v3 = Camera.main.ScreenToWorldPoint(v3);

            Debug.Log(v3);

        }

        braulio.transform.position = Vector3.MoveTowards(braulio.transform.position, v3, 0.5f);

    }

    void OnMouseDown()
    {
       

    }
}
