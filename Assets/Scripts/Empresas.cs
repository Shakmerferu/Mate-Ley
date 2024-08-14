using System.Collections.Generic;
using UnityEngine;

// Clase de datos simple que no extiende de MonoBehaviour
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

    // Constructor
    public Empresa(string nombre, string remitente, string asunto, string textoCorreo, string archivoAdjunto, 
                   string nombreEmpresa, string cuitEmpresa, string domicilioEmpresa, string tipoExportacion, 
                   string numeroDespacho, string pesoCantidad, string destino, string fechaCaducidad)
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
    }
}

// Esta clase extiende de MonoBehaviour porque es usada en Unity
public class GestorEmpresas : MonoBehaviour
{
    public List<Empresa> empresas;

    void Start()
    {
        empresas = new List<Empresa>();

        // Añadir la información de las empresas
        empresas.Add(new Empresa(
            "Dulce Pampa", "exportaciones@dulcepampa.com.ar", "Exportación de Miel - Dulce Pampa",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestra miel bajo la marca \"Dulce Pampa\". Agradecemos su colaboración y quedamos a disposición para cualquier información adicional que necesiten.\nSaludos cordiales.\n\nDulce Pampa\nexportaciones@dulcepampa.com.ar",
            "Certificado de exportación.", "Dulce Pampa", "20-12845378-9", "José Viscardia 500", "Miel",
            "23101EC01000023A", "9Kg", "China", "5/10/24"));

        empresas.Add(new Empresa(
            "Corte Pampeano", "exportaciones@cortepampeano.com.ar", "Exportación de Carne Bovina - Corte Pampeano",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestra carne bovina bajo la marca \"Corte Pampeano\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales\n\nCorte Pampeano\nexportaciones@cortepampeano.com.ar",
            "Certificado de exportación.", "Corte Pampeano", "20-82745277-9", "José Viscardia 1500", "Carne Bovina",
            "23121EC01000023A", "5kg", "Chile", "18/12/24"));

        empresas.Add(new Empresa(
            "Trigo del Valle", "exportaciones@trigodelvalle.com.ar", "Exportación de Trigo - Trigo del Valle",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestro trigo bajo la marca \"Trigo del Valle\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nTrigo del Valle\nexportaciones@trigodelvalle.com.ar",
            "Certificado de exportación.", "Trigo del Valle", "20-89945267-9", "José Viscardia 100", "Trigo",
            "23121EC01000023A", "3kg", "Uruguay", "18/12/24"));

        empresas.Add(new Empresa(
            "Sal del caldén", "exportaciones@saldelcalden.com.ar", "Exportación de Sal - Sal del caldén",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestra sal bajo la marca \"Sal del Caldén\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nSal del caldén\nexportaciones@saldelcalden.com.ar",
            "Certificado de exportación.", "Sal del caldén", "20-97742298-9", "José Viscardia 300", "Sal",
            "23091EC01000023A", "2kg", "Perú", "20/09/24"));

        empresas.Add(new Empresa(
            "Maíz del Campo", "exportaciones@maizdelcampo.com.ar", "Exportación de Maíz - Maíz del Campo",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestro maíz bajo la marca \"Maíz del Campo\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nMaíz del Campo\nexportaciones@maizdelcampo.com.ar",
            "Certificado de exportación.", "Maíz del Campo", "20-22948848-9", "José Viscardia 20", "Maíz",
            "23081EC01000023A", "6kg", "Paraguay", "31/08/24"));

        empresas.Add(new Empresa(
            "TechPampa", "exportaciones@techpampa.com.ar", "Exportación de Software de Transacciones - TechPampa",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestro software de transacciones bajo la marca \"TechPampa\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nTechPampa\nexportaciones@techpampa.com.ar",
            "Certificado de exportación.", "TechPampa", "20-87658449-9", "José Viscardia 25", "Software",
            "23081EC01000023A", "??", "Estados Unidos", "20/08/24"));

        empresas.Add(new Empresa(
            "Aceites del Sol", "exportaciones@aceitesdelsol.com.ar", "Exportación de Aceite de Girasol - Aceites del Sol",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestro aceite de girasol bajo la marca \"Aceites del Sol\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nAceites del sol\nexportaciones@aceitesdelsol.com.ar",
            "Certificado de exportación.", "Aceites del sol", "20-17158141-9", "José Viscardia 750", "Aceite de girasol",
            "23101EC01000023A", "4L", "Chile", "15/10/24"));

        empresas.Add(new Empresa(
            "Cuero Pampeano", "exportaciones@cueropampeano.com.ar", "Exportación de Cuero y Pieles - Cuero Pampeano",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestro cuero y pieles bajo la marca \"Cuero Pampeano\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nCuero Pampeano\nexportaciones@cueropampeano.com.ar",
            "Certificado de exportación.", "Cuero Pampeano", "20-58258845-9", "José Viscardia 250", "Cuero y Pieles",
            "23111EC01000023A", "9kg", "China", "12/11/24"));

        empresas.Add(new Empresa(
            "Semillas del Sol", "exportaciones@semillasdelsol.com.ar", "Exportación de Semillas de Girasol - Semillas del Sol",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestras semillas de girasol bajo la marca \"Semillas del Sol\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nSemillas del Sol\nexportaciones@semillasdelsol.com.ar",
            "Certificado de exportación.", "Semillas del sol", "20-98929895-9", "José Viscardia 150", "Semillas de girasol",
            "23091EC01000023A", "10kg", "Chile", "30/09/24"));

        empresas.Add(new Empresa(
            "YesoPam", "exportaciones@yesopam.com.ar", "Exportación de Manufacturas de Yeso - YesoPam",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestras manufacturas de yeso bajo la marca \"YesoPam\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nYesoPam\nexportaciones@yesopam.com.ar",
            "Certificado de exportación.", "YesoPam", "20-97341981-9", "José Viscardia 750", "Manufacturas de Yeso",
            "23081EC01000023A", "4kg", "Brasil", "24/08/24"));

        empresas.Add(new Empresa(
            "FertiPam", "exportaciones@fertipam.com.ar", "Exportación de Fertilizantes - FertiPam",
            "Estimado equipo de ICOMEX,\nSolicitamos su autorización para exportar nuestro fertilizante bajo la marca \"FertiPam\". Agradecemos su colaboración y estamos a su disposición para proporcionar cualquier información adicional que requieran.\nSaludos cordiales.\n\nFertiPam\nexportaciones@fertipam.com.ar",
            "Certificado de exportación.", "FertiPam", "20-87141817-9", "José Viscardia 650", "Fertilizantes",
            "23081EC01000023A", "20kg", "Brasil", "14/08/24"));
    }
}
