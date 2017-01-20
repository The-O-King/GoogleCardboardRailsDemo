using UnityEngine;
using System.Collections;

public class RainStop : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (transform.position.z > 300 && transform.position.z < 320)
		{
			transform.parent = null;
			transform.position = new Vector3(505, 70, 330);
		}
	}
}
