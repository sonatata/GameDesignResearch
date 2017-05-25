using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale *= 1.1F;
    }

    void OnMouseUp()
    {
        Application.Quit();
    }
}
