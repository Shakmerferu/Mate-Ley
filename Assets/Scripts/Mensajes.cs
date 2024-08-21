using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class Mensaje : MonoBehaviour
{
    public Text textoRemitente;
    public Text textoAsunto;
    public Text textoMensaje;
    public Text textoInformacionAdicional;
    [SerializeField] private Button botonPDF1;
    [SerializeField] private Button botonPDF2;
    [SerializeField] private Button botonPDF3;

    [SerializeField] private InputField inputBusqueda;

    public GestorEmpresa gestorEmpresas;

    private List<Empresa> emailsFiltrados; // Lista para almacenar los emails filtrados

    void Start()
    {
        // Inicializar la lista de emails filtrados
        emailsFiltrados = gestorEmpresas.empresas.Select(empresa => empresa).ToList();
        // Asignar el evento de búsqueda al InputField
        inputBusqueda.onValueChanged.AddListener(BuscarEmail);
    }

    private Empresa ObtenerEmailDesdeEmpresa(int index)
    {
        return emailsFiltrados[index];
    }

    public void OnClickEmail(int index)
    {
        // Obtener la empresa seleccionada de la lista filtrada
        Empresa empresaSeleccionada = ObtenerEmailDesdeEmpresa(index);

        // Mostrar detalles en UI
        textoRemitente.text = empresaSeleccionada.Remitente;
        textoAsunto.text = empresaSeleccionada.Asunto;
        textoMensaje.text = empresaSeleccionada.TextoCorreo;

        // Configurar los botones PDF
        botonPDF1.gameObject.SetActive(gestorEmpresas.pdfButtons[0].activeSelf);
        botonPDF2.gameObject.SetActive(gestorEmpresas.pdfButtons[1].activeSelf);
        botonPDF3.gameObject.SetActive(gestorEmpresas.pdfButtons[2].activeSelf);

        // Actualizar la información adicional para el primer botón de PDF
        if (gestorEmpresas.pdfButtons[0].activeSelf)
        {
            botonPDF1.GetComponent<Button>().onClick.RemoveAllListeners();
            string informacion = $"CuitEmpresa: {empresaSeleccionada.CuitEmpresa}\n" +
                                 $"DomicilioEmpresa: {empresaSeleccionada.DomicilioEmpresa}\n" +
                                 $"TipoExportacion: {empresaSeleccionada.TipoExportacion}\n" +
                                 $"NumeroDespacho: {empresaSeleccionada.NumeroDespacho}\n" +
                                 $"PesoCantidad: {empresaSeleccionada.PesoCantidad}\n" +
                                 $"Destino: {empresaSeleccionada.Destino}\n" +
                                 $"FechaCaducidad: {empresaSeleccionada.FechaCaducidad}";

            botonPDF1.GetComponent<Button>().onClick.AddListener(() => MostrarInformacion(informacion));
        }
    }

    private void BuscarEmail(string textoBusqueda)
    {
        emailsFiltrados = gestorEmpresas.empresas.Where(empresa => empresa.Remitente.ToLower().Contains(textoBusqueda.ToLower()) ||
        empresa.Asunto.ToLower().Contains(textoBusqueda.ToLower()) || 
        empresa.TextoCorreo.ToLower().Contains(textoBusqueda.ToLower())).Select(empresa => empresa).ToList();

        // Actualizar la interfaz de usuario para mostrar los emails filtrados
        // Puedes utilizar un ListView o un sistema de creación de objetos dinámicos para mostrar los resultados
    }

    void MostrarInformacion(string informacion)
    {
        // Aquí podrías mostrar la información en la UI como un cuadro de texto, un popup, etc.
        Debug.Log(informacion);
    }
}
