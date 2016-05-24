using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

	public const int lifePoints = 100;
	public const float speedBoost = 6;
	public const float rotationSpeed = 150;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getLifePoints () {
		return lifePoints;
	}

	public float getSpeedBoost () {
		return speedBoost;
	}

	public float getRotationSpeed () {
		return lifePoints;
	}

}
