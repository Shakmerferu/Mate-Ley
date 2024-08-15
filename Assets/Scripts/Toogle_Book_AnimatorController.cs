using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toogle_Book_AnimatorController : MonoBehaviour
{
    
    public GameObject OpenBookButtonGO, CloseBookButtonGO;

    public Animator animatorController;

    public void OpenBook()
    {
        OpenBookButtonGO.SetActive(false);
        CloseBookButtonGO.SetActive(true);
        animatorController.SetTrigger("introCamera");
    }

    public void CloseBook()
    {
        OpenBookButtonGO.SetActive(true);
        CloseBookButtonGO.SetActive(false);
        animatorController.SetTrigger("outroCamera");
    }
}
