using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class Mensaje : MonoBehaviour
{
    [SerializeField] private Text textoRemitente;
    [SerializeField] private Text textoAsunto;
    [SerializeField] private Text textoMensaje;
    [SerializeField] private Text textoInformacionAdicional;

    [SerializeField] private Button botonPDF1;
    [SerializeField] private Button botonPDF2;
    [SerializeField] private Button botonPDF3;

    [SerializeField] private InputField inputBusqueda;

    public GestorEmpresas gestorEmpresas;

    private List<Email> emailsFiltrados; // Lista para almacenar los emails filtrados

    void Start()
    {
        // Inicializar la lista de emails filtrados
        emailsFiltrados = gestorEmpresas.empresas.Select(empresa => ObtenerEmailDesdeEmpresa(empresas.IndexOf(empresa))).ToList();

        // Asignar el evento de búsqueda al InputField
        inputBusqueda.onValueChanged.AddListener(BuscarEmail);
    }

    public void OnClickEmail(int index)
    {
        // Obtener el email seleccionado de la lista filtrada
        Email emailSeleccionado = emailsFiltrados[index];

        // Mostrar detalles en UI
        textoRemitente.text = emailSeleccionado.remitente;
        // ... (resto del código)
    }

    private void BuscarEmail(string textoBusqueda)
    {
        emailsFiltrados = gestorEmpresas.empresas
            .Where(empresa => empresa.Remitente.ToLower().Contains(textoBusqueda.ToLower()) ||
                              empresa.Asunto.ToLower().Contains(textoBusqueda.ToLower()) ||
                              empresa.TextoCorreo.ToLower().Contains(textoBusqueda.ToLower()))
            .Select(empresa => ObtenerEmailDesdeEmpresa(empresas.IndexOf(empresa)))
            .ToList();

        // Actualizar la interfaz de usuario para mostrar los emails filtrados
        // Puedes utilizar un ListView o un sistema de creación de objetos dinámicos para mostrar los resultados
    }