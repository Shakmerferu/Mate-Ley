using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailManager : MonoBehaviour
{
    public GameObject emailPrefab;
    public Transform contentPanel;

    public List<Email> emails = new List<Email>();

    void MostrarEmails()
    {
        // Limpia el panel de emails antes de mostrar los nuevos
        foreach (Transform child in contentPanel) 
        {
            Destroy(child.gameObject);
        }

        foreach (var email in emails)
        {
            GameObject emailItem = Instantiate(emailPrefab, contentPanel);

            // Obtener referencias a los elementos del prefab
            Text remitenteText = emailItem.transform.Find("RemitenteText").GetComponent<Text>();
            Text asuntoText = emailItem.transform.Find("AsuntoText").GetComponent<Text>();
            Text nivelDificultadText = emailItem.transform.Find("NivelDificultadText").GetComponent<Text>();
            // ... (otros elementos del prefab, como fecha, botón, etc.)

            // Asignar valores a los elementos del prefab
            remitenteText.text = email.remitente;
            asuntoText.text = email.asunto;
            nivelDificultadText.text = email.nivelDificultad;

            // Configurar color del nivel de dificultad (ejemplo)
            switch (email.nivelDificultad)
            {
                case "Verde":
                    nivelDificultadText.color = Color.green;
                    break;
                case "Naranja":
                    nivelDificultadText.color = new Color(1f, 0.65f, 0f); // Naranja
                    break;
                case "Rojo":
                    nivelDificultadText.color = Color.red;
                    break;
            }

            // ... (configurar otros elementos del prefab)
        }
    }
}
