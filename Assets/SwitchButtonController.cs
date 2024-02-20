using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButtonController : MonoBehaviour
{
    private bool isOn  = false;
	[SerializeField] private GameObject usb;

	public void Start()
	{
		usb.SetActive(false);
	}

	public void ToggleSwitch()
	{
			isOn = !isOn;
            if (isOn)
            {
			    transform.Rotate(new Vector3(20f, 0f, 0f));
				usb.SetActive(true);
            } else
            {
			    transform.Rotate(new Vector3(-20f, 0f, 0f));
				usb.SetActive(false);
            }
	}
}
