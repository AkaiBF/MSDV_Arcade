using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjustesGenerales : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static AjustesGenerales Instance;

    public int Volume = 3;
    public int Diff = 2;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
