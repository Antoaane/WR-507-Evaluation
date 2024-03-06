using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinController : MonoBehaviour
{
    [SerializeField] private Transform teleportTarget;
    [SerializeField] private GameObject Rig;
	[SerializeField] private GameManager GameManager;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "XR Origin (XR Rig)")
        {
            if (GameManager.isCodeCompleted() == true)
            {
                GameManager.ShowHint(10);
                Rig.transform.position = teleportTarget.transform.position;
            }
        }
    }
}
