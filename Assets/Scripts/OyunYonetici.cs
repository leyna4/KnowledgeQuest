using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OyunYonetici : MonoBehaviour
{
    public static string dogruRenk = "Kirmizi"; // Bu seviyede istenen balon
    private static int dogruSayisi = 0;

    public static void DogruBalonPatladi()
    {
        dogruSayisi++;
        if (dogruSayisi >= 3)
        {
            Debug.Log("Tebrikler! Tüm doðru balonlarý patlattýn!");
        }
    }
}

