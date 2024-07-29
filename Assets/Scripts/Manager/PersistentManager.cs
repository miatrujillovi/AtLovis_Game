using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    private static PersistentManager instance;
    void Awake()
    {
        if (instance == null)
        {
            // Esto evita que el objeto se destruya a pesar de cambiar la escena
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // O destruira un duplicado
            Destroy(gameObject);
        }
    }
}
