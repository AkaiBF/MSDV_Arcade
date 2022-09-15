using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiffSettings : MonoBehaviour
{
    public Button BDiffUp;
    public Button BDiffDown;
    public Text[] TDiff;
    private Color32 grey;
    private Color32 green;
    // Start is called before the first frame update
    void Awake()
    {
        if (AjustesGenerales.Instance.Diff>2)
        {
            BDiffUp.gameObject.SetActive(false);
        }
        if (AjustesGenerales.Instance.Diff<2)
        {
            BDiffDown.gameObject.SetActive(false);
        }
        UpdateDiff();
    }

    void Update() {}

    public void EscenaMenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void DiffUp()
    {
        BDiffDown.gameObject.SetActive(true);
        if (AjustesGenerales.Instance.Diff<3){
            AjustesGenerales.Instance.Diff++;
        }
        if (AjustesGenerales.Instance.Diff>2){
            BDiffUp.gameObject.SetActive(false);
        }
        UpdateDiff();
    }

    public void DiffDown()
    {
        BDiffUp.gameObject.SetActive(true);
        if (AjustesGenerales.Instance.Diff>1)
        {
            AjustesGenerales.Instance.Diff--;
        }
        if (AjustesGenerales.Instance.Diff<2){
            BDiffDown.gameObject.SetActive(false);
        }
        UpdateDiff();
    }

    public void UpdateDiff()
    {
        foreach(Text text in TDiff)
        {
            text.gameObject.SetActive(false);
        }
        for (int i=0;i<3;i++)
        {
            if (AjustesGenerales.Instance.Diff==i+1)
            {
                TDiff[i].gameObject.SetActive(true);
            }
        }
    }
}
