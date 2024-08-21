using System.Collections.Generic;
using UnityEngine;

public class Empresa
{
    public string Nombre { get; set; }
    public string Remitente { get; set; }
    public string Asunto { get; set; }
    public string TextoCorreo { get; set; }
    public string ArchivoAdjunto { get; set; }
    public string NombreEmpresa { get; set; }
    public string CuitEmpresa { get; set; }
    public string DomicilioEmpresa { get; set; }
    public string TipoExportacion { get; set; }
    public string NumeroDespacho { get; set; }
    public string PesoCantidad { get; set; }
    public string Destino { get; set; }
    public string FechaCaducidad { get; set; }
    public bool EsValido { get; set; }

    public Empresa(string nombre, string remitente, string asunto, string textoCorreo, string archivoAdjunto,
                   string nombreEmpresa, string cuitEmpresa, string domicilioEmpresa, string tipoExportacion,
                   string numeroDespacho, string pesoCantidad, string destino, string fechaCaducidad, bool esValido)
    {
        Nombre = nombre;
        Remitente = remitente;
        Asunto = asunto;
        TextoCorreo = textoCorreo;
        ArchivoAdjunto = archivoAdjunto;
        NombreEmpresa = nombreEmpresa;
        CuitEmpresa = cuitEmpresa;
        DomicilioEmpresa = domicilioEmpresa;
        TipoExportacion = tipoExportacion;
        NumeroDespacho = numeroDespacho;
        PesoCantidad = pesoCantidad;
        Destino = destino;
        FechaCaducidad = fechaCaducidad;
        EsValido = esValido;
    }

    public Empresa GenerarEmailFalso()
    {
        return new Empresa(
            Nombre + " (Falso)",
            Remitente,
            Asunto,
            TextoCorreo + " [Información posiblemente incorrecta]",
            ArchivoAdjunto,
            NombreEmpresa,
            CuitEmpresa,
            DomicilioEmpresa,
            TipoExportacion,
            NumeroDespacho,
            PesoCantidad,
            Destino,
            FechaCaducidad,
            false
        );
    }
}

public class GestorEmpresa : MonoBehaviour
{
    public List<Empresa> empresas;
    public List<GameObject> pdfButtons;  // Referencias a los botones de PDF
    public Empresa empresaActual;

    void Start()
    {
        empresas = new List<Empresa>();

        // Añadir la información de las empresas
        // Ejemplo de inicialización
        empresas.Add(new Empresa("Empresa1", "remitente1@ejemplo.com", "Asunto1", "Texto del correo 1", "archivo1.pdf",
                                  "NombreEmpresa1", "CUIT1", "Domicilio1", "TipoExportacion1", "NumeroDespacho1",
                                  "PesoCantidad1", "Destino1", "FechaCaducidad1", true));
        empresas.Add(new Empresa("Empresa2", "remitente2@ejemplo.com", "Asunto2", "Texto del correo 2", "archivo2.pdf",
                                  "NombreEmpresa2", "CUIT2", "Domicilio2", "TipoExportacion2", "NumeroDespacho2",
                                  "PesoCantidad2", "Destino2", "FechaCaducidad2", true));
        // Agrega más empresas según sea necesario

        // Generar emails falsos basados en la lista de empresas reales
        List<Empresa> emailsFalsos = new List<Empresa>();
        foreach (Empresa empresa in empresas)
        {
            if (Random.value > 0.5f)
            {
                emailsFalsos.Add(empresa.GenerarEmailFalso());
            }
            else
            {
                emailsFalsos.Add(empresa);
            }
        }

        // Seleccionar la primera empresa aleatoriamente (verdadera o falsa)
        empresaActual = emailsFalsos[Random.Range(0, emailsFalsos.Count)];
    }
}
