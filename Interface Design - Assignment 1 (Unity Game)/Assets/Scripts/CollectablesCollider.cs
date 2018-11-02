using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesCollider : MonoBehaviour {

	CollectablesController cc;

	void Start()
	{
		GameObject ccgo = GameObject.Find ("CollectablesController");
		cc = ccgo.GetComponent<CollectablesController>();
	}

	void OnTriggerEnter(Collider col)
	{
		if (gameObject.name.Contains("Aid Box"))
		{
			Debug.Log ("You've collected a useful aid box!");
		}
		else if (gameObject.name.Contains("Gem"))
		{
			Debug.Log ("You've collected a shiny gem!");
		}
		else if (gameObject.name.Contains("Chicken Leg"))
		{
			Debug.Log ("You've collected a tasty chicken leg!");
		}
		//AudioSource audio = GetComponent<AudioSource>();
		//audio.Play();

		cc.IncrementCount (gameObject);
		Destroy (gameObject);
	}
}
