using UnityEngine;
using System.Collections;

public class PlayerInputManager : MonoBehaviour {

	private Rigidbody rb;

	public float rotationSpeed = ResourceManager.rotationSpeed;
	public float speedBoost = ResourceManager.speedBoost;

	private string inputMovementAxisName = "Vertical";
	private string inputRotationAxisName = "Horizontal";

	private float inputMovement;
	private float inputRotation;

	private const double yPositionPlayer = 4.12;

	// Use this for initialization
	void Start () {
		Init ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Rotate ();
	}

	private void Rotate () {
		inputRotation = Input.GetAxis (inputRotationAxisName);
		float turn = inputRotation * rotationSpeed * Time.deltaTime;
		Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f);
		rb.MoveRotation (rb.rotation * turnRotation);
	}

	private void Move () {
		inputMovement = Input.GetAxis (inputMovementAxisName);
		Vector3 movement = transform.forward * speedBoost * inputMovement * Time.deltaTime;
		rb.MovePosition (rb.position + movement);
	}

	public void Init () {
		rb = GetComponent<Rigidbody> ();
	}

	/*private void setPlayerPosition(int x, int z){
		transform.position = new Vector3 (x, yPositionPlayer, z);
	}*/
}
