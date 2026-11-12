using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class AgarreObjetos : MonoBehaviour
{
	public float _maxDistancia = 0.15f;
	public LayerMask _caja;
	public XRKnob xRKnob;
	private Transform _objetoAgarrado = null;

    public void AgarreCaja()
	{
		if (_objetoAgarrado != null)
		{
			SoltarObjeto(_objetoAgarrado);
			return;
		}

		RaycastHit _hit;
		Vector3 _origen = transform.position;
		Vector3[] _direcciones = { transform.forward, -transform.forward, transform.right, -transform.right };

		foreach (Vector3 _direccion in _direcciones)
		{
			if (Physics.Raycast(_origen, _direccion, out _hit, _maxDistancia, _caja))
			{
				Transform _cajaTransform = _hit.collider.transform;
				Vector3 _posicion = _origen + _direccion * 0.2f;

				_posicion.y = _origen.y;
				_cajaTransform.position = _posicion;

				Rigidbody _rb = _cajaTransform.GetComponent<Rigidbody>();
				FixedJoint _jointExistente = _cajaTransform.GetComponent<FixedJoint>();

				if (_rb != null && _jointExistente == null)
				{
					_rb.useGravity = false;
					FixedJoint _joint = _cajaTransform.gameObject.AddComponent<FixedJoint>();
					_joint.connectedBody = GetComponent<Rigidbody>();

					_objetoAgarrado = _cajaTransform;
				}
				break;
			}
		}
	}

	private void SoltarObjeto(Transform _cajaTransform)
	{
		Rigidbody _rb = _cajaTransform.GetComponent<Rigidbody>();
		FixedJoint _jointExistente = _cajaTransform.GetComponent<FixedJoint>();

		if (_rb != null)
			_rb.useGravity = true;

		if (_jointExistente != null)
			Destroy(_jointExistente);

		_objetoAgarrado = null;
	}

	public void EscalarObjeto()
	{
		if (_objetoAgarrado == null)
			return;

		float _escala = Mathf.Lerp(0.11f, 0.2f, xRKnob.value);
		_objetoAgarrado.localScale = new Vector3(_escala, _escala, _escala);
	}

	private void OnDrawGizmos()
	{
		Vector3 _origen = transform.position;
		Vector3[] _direcciones = { transform.forward, -transform.forward, transform.right, -transform.right };

		Gizmos.color = Color.red;
		foreach (Vector3 _direccion in _direcciones)
		{
			Gizmos.DrawRay(_origen, _direccion * _maxDistancia);
		}
	}
}