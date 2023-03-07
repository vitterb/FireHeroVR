using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Hapticfeedback : MonoBehaviour
{
    [Range(0, 1)]
    public float intensity;
    public float duration;

    void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.activated.AddListener(triggerHaptic);
    }

    public void triggerHaptic(BaseInteractionEventArgs eventargs)
    {
        if (eventargs.interactableObject is XRBaseControllerInteractor controllerInteractor)
        {
            triggerHaptic(controllerInteractor.xrController);
        }
    }
    public void triggerHaptic(XRBaseController controller)
    { 
        if (intensity > 0)
        {
            controller.SendHapticImpulse(intensity, duration);
        }
    }

}
