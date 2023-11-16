using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Selector : MonoBehaviour
{
    [SerializeField]
    Transform rayOrigin;
    [SerializeField]
    Material saveMaterial;
    Transform selectedobject; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out hit))
        {
            {
                Debug.DrawLine(rayOrigin.position, rayOrigin.position + rayOrigin.forward * hit.distance, Color.red);

            }
            Debug.Log(hit.transform.name + "." + hit.distance);
            Renderer r = hit.transform.GetComponent<Renderer>();
            if (r != null)

                if (selectedobject != null && hit.transform != selectedobject)
                {
                    selectedobject.GetComponent<Renderer>().sharedMaterial = saveMaterial;
                }
                if (selectedobject != hit.transform)

                selectedobject= hit.transform;
            saveMaterial = r.sharedMaterial;
            r.material.color = Color.red;
        }
        { }

        {
            
        }
        }
        
    }
    
