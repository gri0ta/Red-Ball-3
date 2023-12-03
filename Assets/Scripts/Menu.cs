using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject StartScreen;

    private void OnMouseDown()
    {
        transform.position += Vector3.down * 0.1f;

    }

    private void OnMouseUp()
    {
        StartScreen.SetActive(false);
        transform.position += Vector3.up * 0.1f;

    }
}
