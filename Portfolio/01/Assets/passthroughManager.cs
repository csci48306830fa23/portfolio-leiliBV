using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passthroughManager : MonoBehaviour
{
    public OVRPassthroughLayer passthrough;
    public OVRInput.Button button;
    public OVRInput.Controller controller;
    public List<Gradient> colorMapGradient;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button,controller))
        {
            passthrough.hidden = !passthrough.hidden;
            
        }

    }


    public void SetOpacity(float value)
    {
        passthrough.textureOpacity = value;
    }


    public void SetColorMapGradient(int index)
    {
        passthrough.colorMapEditorGradient = colorMapGradient[index];
    }
}
