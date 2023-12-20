using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCreater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OVRSceneRoom room = FindAnyObjectByType<OVRSceneRoom>();
        OVRScenePlane ceiling = room.Ceiling;
        Vector2 localPoint = ceiling.Boundary[0];
        Vector3 worldPoint = ceiling.transform.TransformPoint(localPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
