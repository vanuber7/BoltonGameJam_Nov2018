using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour 
{
	[SerializeField] Rigidbody _playerRigidbody;
	[SerializeField] Transform _playerTransform;
	[SerializeField] float _moveForwardVelocity;
	[SerializeField] float _moveBackwardVelocity;
	[SerializeField] float _turningSpeed;

	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Move();
		Turn();
	}


	void Move()
	{
		// Move player using their velocity
		if(Input.GetKey(KeyCode.W))
		{
			_playerRigidbody.velocity = (_playerTransform.forward * _moveForwardVelocity * Time.fixedDeltaTime) / _playerRigidbody.mass;
		}
		else if(Input.GetKey(KeyCode.S))
		{
			_playerRigidbody.velocity = (-_playerTransform.forward * _moveBackwardVelocity * Time.fixedDeltaTime) / _playerRigidbody.mass;
		}
	}


	void Turn()
	{
		// Turn player left and right
		if(Input.GetKey(KeyCode.A))
		{
			Quaternion rotation = Quaternion.AngleAxis(-_turningSpeed * Time.fixedDeltaTime, transform.up);
			Quaternion newRotation = _playerRigidbody.rotation * rotation;
			_playerRigidbody.MoveRotation(newRotation);			
		}
		else if(Input.GetKey(KeyCode.D))
		{
			Quaternion rotation = Quaternion.AngleAxis(_turningSpeed * Time.fixedDeltaTime, transform.up);
			Quaternion newRotation = _playerRigidbody.rotation * rotation;
			_playerRigidbody.MoveRotation(newRotation);
		}		
	}
}
