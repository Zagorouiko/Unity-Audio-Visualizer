using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerper : MonoBehaviour {

    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.PingPong(Time.time, transform.localPosition.x), transform.localPosition.y, transform.localPosition.z);
    }
}
