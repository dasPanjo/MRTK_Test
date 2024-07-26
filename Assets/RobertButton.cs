using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RobertButton : MonoBehaviour
{
    [SerializeField] TextMeshPro textMesh;


    public void Pressed()
    {
        Debug.Log("Pressed");
        textMesh.text = "Pressed";
    }

    public void Released()
    {
        Debug.Log("Released");
        textMesh.text = "Released";
    }

    public void Begin()
    {
        Debug.Log("Begin");
        textMesh.text = "Begin";
    }

    public void End()
    {
        Debug.Log("End");
        textMesh.text = "End";

    }
}
