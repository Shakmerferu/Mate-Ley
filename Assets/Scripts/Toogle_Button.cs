using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    public Sprite spriteActivo;
    public Sprite spritePasivo;
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = spritePasivo; // Inicializamos el botón en estado pasivo
    }

    public void ToggleState()
    {
        if (image.sprite == spritePasivo)
        {
            image.sprite = spriteActivo;
        }
        else
        {
            image.sprite = spritePasivo;
        }
    }
}
