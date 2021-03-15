using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DatuIzvade : MonoBehaviour
{

    public string vecums;
    public string teksts;
    public GameObject vecumaLauks;
    public GameObject tekstaLauks;
    public GameObject tekstaAttelosana;

    public void uzglabatTekstu()
    {
        vecums = vecumaLauks.GetComponent<Text>().text;
        teksts = tekstaLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = teksts+" ir "+vecums+" gadus vecs!";
    }

}
