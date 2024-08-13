using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Empresas : MonoBehaviour
{
    [System.Serializable]
    public class Empresa
    {
        public string nombre;
        public string remitente;
        public string asunto;
        public string textoCorreo;
        public string archivoAdjunto;
        // ... (otros campos si los necesitas)
    }

    public List<Empresa> empresas = new List<Empresa>();

    public GameObject panelCabecera;
    public GameObject panelCuerpo;
    public Text txtRemitenteCabecera;
    public Text txtAsuntoCabecera;
    public Text txtCuerpo;
    public Image imgArchivoAdjunto; // Para mostrar la imagen del adjunto
    public GameObject panelDetallesAdjunto; // Panel dentro de panelCuerpo para los detalles

    void Start()
    {
        // ... (código para inicializar las empresas)

        // Ocultar los paneles al inicio
        panelCabecera.SetActive(false);
        panelCuerpo.SetActive(false);
        panelDetallesAdjunto.SetActive(false);
    }

    public void MostrarInformacion(int indice)
    {
        // Mostrar la cabecera
        panelCabecera.SetActive(true);
        txtRemitenteCabecera.text = empresas[indice].remitente;
        txtAsuntoCabecera.text = empresas[indice].asunto;

        // Mostrar el cuerpo
        panelCuerpo.SetActive(true);
        txtCuerpo.text = empresas[indice].textoCorreo;

        // Mostrar los detalles del adjunto (si están disponibles)
        panelDetallesAdjunto.SetActive(!string.IsNullOrEmpty(empresas[indice].archivoAdjunto));
        // ... (llenar los campos de texto con los detalles del adjunto)

        // Cargar la imagen del adjunto (si está disponible)
        if (!string.IsNullOrEmpty(empresas[indice].archivoAdjunto))
        {
            // Asumiendo que tienes la ruta de la imagen en empresas[indice].archivoAdjunto
            // Reemplaza "Resources" con la ruta correcta si es necesario
            byte[] bytes = File.ReadAllBytes(Application.dataPath + "/Resources/" + empresas[indice].archivoAdjunto);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(bytes);
            imgArchivoAdjunto.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        }
    }
}
