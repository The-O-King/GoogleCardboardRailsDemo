using UnityEngine;
using System.Collections;

public class StartControls : MonoBehaviour {
	public bool started = false;

	// Use this for initialization
	void Start () {
		Debug.Log ("Started");
		gameObject.GetComponent<Cardboard>().VRModeEnabled = true;
		gameObject.GetComponent<Cardboard>().TapIsTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Cardboard>().CardboardTriggered)
			Debug.Log (true);
		if (GetComponent<Cardboard>().CardboardTriggered && started == false)
		{
			GetComponent<SplineController>().FollowSpline ();
			started = true;
		}
		if (gameObject.GetComponent<Cardboard>().VRModeEnabled)
			Debug.Log("asdasdasdas");
	}
}
