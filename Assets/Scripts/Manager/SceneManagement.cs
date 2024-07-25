using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void JugarTurno()
    {
        SceneManager.LoadScene(sceneName: "Gameplay");
    }

    public void Personajes()
    {
        SceneManager.LoadScene(sceneName: "Personajes");
    }

    public void MejoraTienda()
    {
        SceneManager.LoadScene(sceneName: "Tienda");
    }

    public void Gachapon()
    {
        SceneManager.LoadScene(sceneName: "Gachapon");
    }
}
