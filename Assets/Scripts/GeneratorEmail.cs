using System.Collections.Generic;
using UnityEngine;

public class EmailGenerator : MonoBehaviour
{
    public EmailManager emailManager;

    private string[][] empresas = new string[][]
    {
        new string[] { "AgroExport Pampeano", "Trigo, Maíz, Soja, Girasol", "SENASA, Certificado de Calidad, Certificado Fitosanitario, Certificado de No OMG, Certificado de Origen" },
        new string[] { "Lácteos La Esperanza", "Queso, Leche en Polvo, Manteca", "SENASA, Certificado Sanitario, Certificado de Calidad, Certificado de Pureza" },
        new string[] { "TextilPico", "Lana, Algodón, Tejidos", "INASE, SENASA, Certificado de Origen, Certificado de Calidad" },
        new string[] { "Metalúrgica del Oeste", "Maquinaria Agrícola, Autopartes", "IRAM, Certificado de Seguridad, Certificado de Calidad" },
        new string[] { "EnergíaRenovableSur", "Paneles Solares, Aerogeneradores", "Certificado de Eficiencia Energética, Certificado de Calidad, Certificado de Seguridad" },
        new string[] { "Alimentos Pampeanos", "Harina de Trigo, Aceite de Girasol, Miel", "ANMAT, SENASA, Certificado de Calidad, Certificado de Pureza" }
        // ... (agrega más empresas y datos)
    };

    private string[] asuntos = {
        "Solicitud de autorización de exportación de {producto} desde la ZFGP",
        "Informe de cumplimiento de normas para exportación de {producto} desde la ZFGP",
        "Consulta sobre documentación de exportación de {producto} desde la ZFGP",
        "Notificación de inspección de {producto} para exportación desde la ZFGP",
        "Solicitud de certificado de origen para {producto} exportado desde la ZFGP",
        "Aviso de retraso en el envío de {producto} desde la ZFGP",
        "Confirmación de pago de tasas de exportación de {producto} desde la ZFGP"
        // ... (más asuntos)
    };

    void Start()
    {
        GenerarEmails(Random.Range(1, 6));
    }

    void GenerarEmails(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            Email email = new Email();

            string[] empresaData = empresas[Random.Range(0, empresas.Length)];
            string nombreEmpresa = empresaData[0];
            string[] productos = empresaData[1].Split(',');
            string producto = productos[Random.Range(0, productos.Length)].Trim();
            string[] certificados = empresaData[2].Split(',');

            email.remitente = nombreEmpresa;
            email.asunto = asuntos[Random.Range(0, asuntos.Length)].Replace("{producto}", producto);
            email.nivelDificultad = GetRandomDificultad();

            switch (email.nivelDificultad)
            {
                case "Verde":
                    email.documentos = new string[] { "Factura comercial", "Packing list", "Certificado de origen" };
                    break;
                case "Naranja":
                    email.certificado = certificados[Random.Range(0, certificados.Length)].Trim();
                    break;
                case "Rojo":
                    // ... (Cargar imágenes de mercancía)
                    break;
            }

            emailManager.emails.Add(email);
        }

        emailManager.MostrarEmails();
    }

    string GetRandomDificultad()
    {
        int randomIndex = Random.Range(0, 3);
        return randomIndex == 0 ? "Verde" : (randomIndex == 1 ? "Naranja" : "Rojo");
    }
}
