using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HMDInputManager : MonoBehaviour
{
    [SerializeField] GameObject VRRig;
    [SerializeField] GameObject FPSRig;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Using device: " + XRSettings.loadedDeviceName);

        if (XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "OpenXR Display")
        {
            Debug.Log("VR Rig Active Using device: " + XRSettings.loadedDeviceName);
            FPSRig.SetActive(false);
        
        }
        else
        {
            Debug.Log("Using FPS Rig" + XRSettings.loadedDeviceName);
            VRRig.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
