using UnityEngine;
using System.Collections;

public class WatcherController : MonoBehaviour 
{
	public Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
}
