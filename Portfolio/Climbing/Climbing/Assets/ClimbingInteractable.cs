using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



public class ClimbingInteractable : XRBaseInteractable
{
    protected override void OnSelectEnter(XRBaseInteractable interactor)
    {
        base.onSelectEnter(interactor);

        Debug.Log("SELECT ENTER");
        
    }

    protected override void OnSelectExit(XRBaseInteractor)
    {
        base.OnSelectExit(interactor);
        Debug.Log("SELECT EXIT");
    }
    {
        
    }
}
