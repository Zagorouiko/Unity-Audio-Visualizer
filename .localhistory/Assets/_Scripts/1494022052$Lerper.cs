using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerper : MonoBehaviour {

    public float speed = .1f;

    private Vector3 start;
    private Vector3 des;
    private float fraction = 0;

    void Start () {
        start = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        des = new Vector3(2.0f, transform.position.y, transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
	    if (fraction < 1)
	    {
	        fraction += Time.deltaTime * speed;
	        transform.position = Vector3.Lerp(start, des, fraction);
	    }
    }
}
