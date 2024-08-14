using UnityEngine;
using UnityEngine.UI;

public class Mensaje : MonoBehaviour
{
    public string remitente;  // Remitente
    public string asunto;     // Asunto
    public string textoMensaje; // Texto del mensaje

    public bool activarPDF1;  // Activar botón PDF1
    public bool activarPDF2;  // Activar botón PDF2
    public bool activarPDF3;  // Activar botón PDF3

    public Button botonPDF1;  // Botón para PDF1
    public Button botonPDF2;  // Botón para PDF2
    public Button botonPDF3;  // Botón para PDF3

    void Start()
    {
        // Configurar botones según los booleanos
        botonPDF1.gameObject.SetActive(activarPDF1);
        botonPDF2.gameObject.SetActive(activarPDF2);
        botonPDF3.gameObject.SetActive(activarPDF3);
    }

    // Método para inicializar los datos del mensaje
    public void Inicializar(string remitente, string asunto, string textoMensaje, bool activarPDF1, bool activarPDF2, bool activarPDF3)
    {
        this.remitente = remitente;
        this.asunto = asunto;
        this.textoMensaje = textoMensaje;
        this.activarPDF1 = activarPDF1;
        this.activarPDF2 = activarPDF2;
        this.activarPDF3 = activarPDF3;

        // Configurar los botones al inicializar
        botonPDF1.gameObject.SetActive(activarPDF1);
        botonPDF2.gameObject.SetActive(activarPDF2);
        botonPDF3.gameObject.SetActive(activarPDF3);
    }
}
