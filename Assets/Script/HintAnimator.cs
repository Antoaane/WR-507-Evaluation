using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintAnimator : MonoBehaviour
{
    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float speed = 1f;
    private Vector3 newPos;
    private float startPositionY;

    void Start()
    {
        startPositionY = transform.position.y;
        speed = Random.Range (speed, speed+1f);
    }

    void Update()
    {
        newPos.y = startPositionY + amplitude * Mathf.Sin( speed + Time.time);
        newPos.x = transform.position.x;
        newPos.z = transform.position.z;

        transform.position = newPos;
    }
}
