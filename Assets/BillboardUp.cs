using UnityEngine;
using System.Collections;

public class BillboardUp : MonoBehaviour {

	public GameObject messageTwo;

	IEnumerator OnTriggerEnter()
	{
		GetComponentInParent<SplineController>().FollowSpline();
		yield return new WaitForSeconds(15);
		Debug.Log ("Message Two");
		GetComponentInParent<Transform>().transform.root.gameObject.SetActive (false);
		messageTwo.SetActive(true);
	}
}
