using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Routing : MonoBehaviour
{
    private string gameScene = "SampleScene";
    private string settingsScene = "Ajustes";
    private string mainMenu = "MainMenu";

    void Start() {}
    void Update() {}
    public void EscenaJuego()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void EscenaAjustes()
    {
        SceneManager.LoadScene(settingsScene);
    }

    public void EscenaMenuPrincipal()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
