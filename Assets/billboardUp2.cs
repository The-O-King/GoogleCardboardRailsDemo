using UnityEngine;
using System.Collections;

public class billboardUp2 : MonoBehaviour {

	public GameObject messageThree;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(5);
		messageThree.gameObject.SetActive(true);
		this.gameObject.SetActive (false);
	}
}
