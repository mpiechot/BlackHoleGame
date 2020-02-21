using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BHBlackHole : MonoBehaviour
{

    private void Update()
    {
        CheckForAttractedObjects();
    }

    private void CheckForAttractedObjects()
    {

    }

    private Vector3 Attract(Transform attractedObject)
    {
        return Vector3.zero;
    }
}
