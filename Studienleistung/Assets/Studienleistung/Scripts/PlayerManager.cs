using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	private int lifePoints = ResourceManager.lifePoints;
	private float speedBoost = ResourceManager.speedBoost;
	private float rotationSpeed = ResourceManager.rotationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void lostCondition (int lifePoints) {
		this.lifePoints = lifePoints;
		if (lifePoints <= 0) {
			Debug.Log ("Game Lost!");
		}
	}
}
