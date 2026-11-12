using TMPro;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class RobotVolador : MonoBehaviour
{
	public XRLever _xRLever;
	public XRSlider _xRSlider;
	public Transform _robot;

    public void Volar() 
	{
		if(_xRLever.value == true) 
		{
			Debug.Log("<color=green>esta volando</color>");
		}
		else if (_xRLever.value == false)
		{
			Debug.Log("<color=red>No esta volando</color>");
		}
		Altura();
	}
	

	public void Altura()
	{
		float _alturaActual = _xRSlider.value;
		Vector3 _posicionRobot = _robot.localPosition;

		if (_xRLever.value == true)
		{

			switch (_alturaActual)
			{
				case >= 0f and < 0.25F:
					Debug.Log("<color=blue>P1</color>");
					_alturaActual = 0.2f;
					break;

				case >= 0.25f and <= 0.5f:
					Debug.Log("<color=yellow>P2</color>");
					_alturaActual = 0.45f;
					break;

				case >= 0.5f and < 0.75f:
					Debug.Log("<color=yellow>P2</color>");
					_alturaActual = 0.45f;
					break;

				case >= 0.75f and <= 1f:
					Debug.Log("<color=magenta>P3</color>");
					_alturaActual = 0.65f;
					break;
			}
		}
		else 
		{
			_alturaActual = 0.2f;
		}
		_posicionRobot.y = _alturaActual;
		_robot.localPosition = _posicionRobot;
	}
}