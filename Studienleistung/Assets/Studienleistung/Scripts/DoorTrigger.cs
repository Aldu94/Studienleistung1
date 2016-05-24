using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	private BoxCollider trigger;
	private Doors door;

	// Use this for initialization
	void Start () {
		Init ();
	}
	
	// Update is called once per frame
	void Update () {
		triggerEnter ();
	}

	private void Init () {
		trigger = gameObject.GetComponent<BoxCollider> ();
	}

	private void triggerEnter () {
		door.open ();
	}

	public void setDoor (Doors door) {
		this.door = door;
	}
}
