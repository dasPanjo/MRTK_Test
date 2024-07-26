using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Vector3 targetPos;
    Vector3 targetRot;

    private void Start()
    {
        targetPos = transform.position;
    }

    public void FindNewPosition()
    {
        targetPos = new Vector3(
            Random.Range(-2, 2),
            0,
            Random.Range(-2, 2));

        targetRot += transform.up * Random.Range(0, 360);
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 0.5f);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(targetRot), Time.deltaTime * 0.5f);
    }
}
