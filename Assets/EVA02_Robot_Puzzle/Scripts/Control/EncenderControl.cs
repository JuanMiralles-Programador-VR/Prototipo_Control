using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class EncenderControl : MonoBehaviour
{
    [SerializeField] private GameObject _controles;
    [SerializeField] private GameObject _joystick;
    [SerializeField] private GameObject _lever;
    [SerializeField] private GameObject _Knob;
    [SerializeField] private GameObject _slider;
    [SerializeField] private GameObject _gripButton;

    private MovimientoRobot _movimientoRobot;
    private RobotVolador _robotVolador;
    private XRJoystick _scriptJoystick;
    private XRLever _scriptLever;
    private XRKnob _scriptKnob;
    private XRSlider _scriptSlider;
    private XRGripButton _scriptGripButton;


    private void Start()
    {

        _movimientoRobot = _controles.GetComponent<MovimientoRobot>();
        _robotVolador = _controles.GetComponent<RobotVolador>();

        _scriptJoystick = _joystick.GetComponent<XRJoystick>();
        _scriptLever = _lever.GetComponent<XRLever>();
        _scriptKnob = _Knob.GetComponent<XRKnob>();
        _scriptSlider = _slider.GetComponent<XRSlider>();
        _scriptGripButton = _gripButton.GetComponent<XRGripButton>();

        _movimientoRobot.enabled = false;
        _robotVolador.enabled = false;
        _scriptJoystick.enabled = false;
        _scriptLever.enabled = false;
        _scriptKnob.enabled = false;
        _scriptSlider.enabled = false;
        _scriptGripButton.enabled = false;
    }

    public void Activar () 
    { 
        _movimientoRobot.enabled = true;
        _robotVolador.enabled = true;
        _scriptJoystick.enabled = true;
        _scriptLever.enabled = true;
        _scriptKnob.enabled = true;
        _scriptSlider.enabled = true;
        _scriptGripButton.enabled = true;
        Debug.Log("<color=green>Activado</color>");
    }
    public void Desactivar()
    {
        _movimientoRobot.enabled = false;
        _robotVolador.enabled = false;
        _scriptJoystick.enabled = false;
        _scriptLever.enabled = false;
        _scriptKnob.enabled = false;
        _scriptSlider.enabled = false;
        _scriptGripButton.enabled = false;
        Debug.Log("<color=red>Desactivado</color>");
    }
}
