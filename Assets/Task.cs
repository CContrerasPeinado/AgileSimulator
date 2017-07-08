using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour {

    public GameObject taskObject;

    // Update is called once per frame
	void Update () {
        taskObject.transform.Translate(0, 0, 0.01f);
	}
}
