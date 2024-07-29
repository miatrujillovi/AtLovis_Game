using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgain : MonoBehaviour
{
    public GameObject manager;
    public GameObject canvas;

    public void Again()
    {
        manager.SetActive(true);
        canvas.SetActive(false);
    }
}
