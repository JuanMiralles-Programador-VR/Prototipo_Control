using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class MandoGrabInteractable : XRGrabInteractable
{
	[Header("Puntos de agarre")]
	[SerializeField] private Transform agarreIzquierdo;
	[SerializeField] private Transform agarreDerecho;

	[Header("Controladores")]
	[SerializeField] private Transform leftController;
	[SerializeField] private Transform rightController;

	public override Transform GetAttachTransform(IXRInteractor interactor)
	{
		// Mano izquierda
		if (interactor.transform.IsChildOf(leftController))
		{
			return agarreIzquierdo;
		}

		// Mano derecha
		if (interactor.transform.IsChildOf(rightController))
		{
			return agarreDerecho;
		}

		// Si no encuentra ninguna
		return base.GetAttachTransform(interactor);
	}
}