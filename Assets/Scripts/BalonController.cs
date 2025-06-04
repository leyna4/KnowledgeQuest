using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BalonController : MonoBehaviour
{
    public string balonRengi; // Inspector'dan ayarlanacak

    private void OnMouseDown()
    {
        if (balonRengi == OyunYonetici.dogruRenk)
        {
            Debug.Log("Doðru balon patlatýldý!");
            Destroy(gameObject);
            OyunYonetici.DogruBalonPatladi();
        }
        else
        {
            Debug.Log("Bu yanlýþ renk. Tekrar dene!");
        }
    }
}

