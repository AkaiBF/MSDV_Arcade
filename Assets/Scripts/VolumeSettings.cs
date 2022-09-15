using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeSettings: MonoBehaviour
{
    public Button BVolumeUp;
    public Button BVolumeDown;
    public Image[] BarraVol;
    private Color32 grey;
    private Color32 green;

    // Start is called before the first frame update
    void Awake()
    {
        grey = new Color32(116, 116, 116, 100);
        green = new Color32(50, 255, 0, 100);
        if (AjustesGenerales.Instance.Volume>4)
        {
            BVolumeUp.gameObject.SetActive(false);
        }
        if (AjustesGenerales.Instance.Volume<1)
        {
            BVolumeDown.gameObject.SetActive(false);
        }
        UpdateVolumeBar();
    }

    void Update() {}

    public void UpdateVolumeBar() {
        foreach(Image image in BarraVol) {
            image.color = grey;
        }
        for(int i = 0; i < AjustesGenerales.Instance.Volume; i++) {
            BarraVol[i].color = green;
        }
    }

    public void VolumeUp()
    {
        BVolumeDown.gameObject.SetActive(true);
        if (AjustesGenerales.Instance.Volume<5){
            AjustesGenerales.Instance.Volume++;
        }
        if (AjustesGenerales.Instance.Volume>4){
            BVolumeUp.gameObject.SetActive(false);
        }
        UpdateVolumeBar();
    }

    public void VolumeDown()
    {
        BVolumeUp.gameObject.SetActive(true);
        if (AjustesGenerales.Instance.Volume>0){
            AjustesGenerales.Instance.Volume--;
        }
        if (AjustesGenerales.Instance.Volume<1){
            BVolumeDown.gameObject.SetActive(false);
        }
        UpdateVolumeBar();
    }
    public void EscenaPausa ()
    {
        SceneManager.LoadScene("MenuPausa");
    }
}
