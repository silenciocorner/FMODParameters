using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalParameter : MonoBehaviour
{
    [SerializeField]
    [Range(0f, 1f)]
    private float eq;

    void Update()
    {
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("EQ Global", eq);
    }
}
