using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrenController : MonoBehaviour
{
    [SerializeField] private Material BlackMaterial;
    [SerializeField] private Material CameraMaterial;
    [SerializeField] private GameObject Screen1;
    [SerializeField] private GameObject Screen2;
    [SerializeField] private GameObject Screen3;
    [SerializeField] private GameObject Screen4;
    [SerializeField] private GameObject Screen5;
    [SerializeField] private GameObject Screen6;
    [SerializeField] private GameObject Projecteur;

    // Start is called before the first frame update
    void Start()
    {
        Screen1.GetComponent<Renderer>().material = BlackMaterial;
        Screen2.GetComponent<Renderer>().material = BlackMaterial;
        Screen3.GetComponent<Renderer>().material = BlackMaterial;
        Screen4.GetComponent<Renderer>().material = BlackMaterial;
        Screen5.GetComponent<Renderer>().material = BlackMaterial;
        Screen6.GetComponent<Renderer>().material = BlackMaterial;
        Projecteur.GetComponent<Renderer>().material = BlackMaterial;
    }

    public void PlugUsb()
    {
        Screen1.GetComponent<Renderer>().material = CameraMaterial;
        Screen2.GetComponent<Renderer>().material = CameraMaterial;
        Screen3.GetComponent<Renderer>().material = CameraMaterial;
        Screen4.GetComponent<Renderer>().material = CameraMaterial;
        Screen5.GetComponent<Renderer>().material = CameraMaterial;
        Screen6.GetComponent<Renderer>().material = CameraMaterial;
        Projecteur.GetComponent<Renderer>().material = CameraMaterial;
    }
}
