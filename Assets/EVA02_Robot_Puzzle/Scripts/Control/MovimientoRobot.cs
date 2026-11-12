using JetBrains.Annotations;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class MovimientoRobot : MonoBehaviour
{
	public XRJoystick _joystick;
	public Transform _robot;
	public float _velocidad = 1f;
	private Rigidbody _rb;
	private Vector3 _direccion = Vector3.zero;
    public void Start()
	{
		_rb = _robot.GetComponent<Rigidbody>();
		_rb.isKinematic = true;
	}
	public void Movimiento()
	{
		// X despues Y orden de como se pone un vector
		float _vauleX = _joystick.value.x;
		float _vauleY = _joystick.value.y;
		
		
		switch (_vauleX, _vauleY)
		{
				case var (x, y) when Mathf.Abs(x) > Mathf.Abs(y) && x > 0:
					Debug.Log("Derecha");
					_direccion = Vector3.right;
					break;

				case var (x, y) when Mathf.Abs(x) > Mathf.Abs(y) && x < 0:
					Debug.Log("Izquierda");
					_direccion = Vector3.left;
					break;

				case var (x, y) when Mathf.Abs(y) > Mathf.Abs(x) && y > 0:
					Debug.Log("Arriba");
					_direccion = Vector3.forward;
					break;

				case var (x, y) when Mathf.Abs(y) > Mathf.Abs(x) && y < 0:
					Debug.Log("Abajo");
					_direccion = Vector3.back;
					break;

				default:
					_direccion = Vector3.zero;
					break;
		}
		MoverRobot();
    }
	public void MoverRobot() 
	{
		if (_direccion == Vector3.zero) return;
		Debug.Log("MoverRobot ejecutando. Direccion: " + _direccion + " Velocidad: " + _velocidad + " RB null? " + (_rb == null));
		if (_rb != null)
		{
			_rb.MovePosition(_robot.position + _direccion * _velocidad * Time.deltaTime);
		}
	}
}
