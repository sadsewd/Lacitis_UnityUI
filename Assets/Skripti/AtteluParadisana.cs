using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    int skait = 0;
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanotM;
    public AudioClip skanaKoAtskanotV;
    public GameObject BruniApaviM;
    public GameObject ZaliZabakiM;
    public GameObject SarkanasBotesM;
    public GameObject CepureM;
    public GameObject CepureM1;
    public GameObject CepureM2;
    public GameObject MetelisM;
    public GameObject LietusMetelisM;
    public GameObject KleitaM;
    public GameObject KleitaM1;
    public GameObject KleitaM2;
    public GameObject BiksesM;
    public GameObject BiksesM1;
    public GameObject SortiM;
    public GameObject SvarkiM;
    public GameObject VederSominaM;
    public GameObject RokasSominaM;
    public GameObject RokasSominaM1;
    public GameObject KreklsM;
    public GameObject KreklsM1;
    public GameObject dzemperisM;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject SomaV;
    public GameObject SomaV1;
    public GameObject KeponsV;
    public GameObject KeponsV1;
    public GameObject SortiV;
    public GameObject MetelisV;
    public GameObject CepureV;
    public GameObject CepureV1;
    public GameObject JakaV;
    public GameObject BiksesV;
    public GameObject BiksesV1;
    public GameObject BiksesV2;
    public GameObject BiksesV3;
    public GameObject BiksesV4;
    public GameObject BiksesV5;
    public GameObject BiksesV6;
    public GameObject KreklsArZaketiV;
    public GameObject KreklsArZaketiV1;
    public GameObject KreklsV;
    public GameObject KreklsV1;
    public GameObject KurpesV;
    public GameObject KurpesV1;
    public GameObject KurpesV2;
    public GameObject KurpesV3;
    public GameObject KurpesV4;
    public GameObject KurpesV5;
    public GameObject KurpesV6;
    public GameObject DzemperisV;
    public GameObject SaulesbrillesV;
    public GameObject SaulesbrillesV1;
    public GameObject TKreklsV;
    public GameObject TKreklsV1;
    public GameObject VirsjakaMT;
    public GameObject KleitasMT;
    public GameObject AksesuariMT;
    public GameObject GalvassegasMT;
    public GameObject ApaksdalaMT;
    public GameObject AugsdalaMT;
    public GameObject ApaviMT;
    public GameObject VirsjakasVT;
    public GameObject AksesuariVT;
    public GameObject GalvassegasVT;
    public GameObject ApaksdalaVT;
    public GameObject AugsdalaVT;
    public GameObject ApaviVT;

    public void VirsjakasM(bool vert)
    {
         LietusMetelisM.SetActive(vert);
        MetelisM.SetActive(vert);
    }
public void KleitasM(bool vert)
    {
        KleitaM.SetActive(vert);
        KleitaM1.SetActive(vert);
        KleitaM2.SetActive(vert);
    }
    public void AksesuariM(bool vert)
    {
        VederSominaM.SetActive(vert);
        RokasSominaM.SetActive(vert);
        RokasSominaM1.SetActive(vert);
    }
    public void GalvassegasM(bool vert)
    {
    CepureM.SetActive(vert);
    CepureM1.SetActive(vert);
    CepureM2.SetActive(vert);
    }
    public void ApaksdalaM(bool vert)
    {
        BiksesM.SetActive(vert);
        BiksesM1.SetActive(vert);
        SortiM.SetActive(vert);
        SvarkiM.SetActive(vert);
    }
    public void AugsdalaM(bool vert)
    {
        dzemperisM.SetActive(vert);
        KreklsM.SetActive(vert);
        KreklsM1.SetActive(vert);
    }
    public void ApaviM(bool vert)
    {
        BruniApaviM.SetActive(vert);
        ZaliZabakiM.SetActive(vert);
        SarkanasBotesM.SetActive(vert);
    }
    public void VirsjakasV(bool vert)
    {
        MetelisV.SetActive(vert);
    }
    
    public void AksesuariV(bool vert)
    {
        SaulesbrillesV.SetActive(vert);
        SaulesbrillesV1.SetActive(vert);
    }
    public void GalvassegasV(bool vert)
    {
        CepureV.SetActive(vert);
        CepureV1.SetActive(vert);
        KeponsV.SetActive(vert);
        KeponsV1.SetActive(vert);
    }
    public void ApaksdalaV(bool vert)
    {
        BiksesV.SetActive(vert);
        BiksesV1.SetActive(vert);
        BiksesV2.SetActive(vert);
        BiksesV3.SetActive(vert);
        BiksesV4.SetActive(vert);
        BiksesV5.SetActive(vert);
        BiksesV6.SetActive(vert);
        SortiV.SetActive(vert);
      
    }
    public void AugsdalaV(bool vert)
    {
        DzemperisV.SetActive(vert);
        KreklsV.SetActive(vert);
        KreklsV1.SetActive(vert);
        JakaV.SetActive(vert);
        KreklsArZaketiV.SetActive(vert);
        KreklsArZaketiV1.SetActive(vert);
        TKreklsV.SetActive(vert);
        TKreklsV1.SetActive(vert);
    }
    public void ApaviV(bool vert)
    {
        KurpesV.SetActive(vert);
        KurpesV1.SetActive(vert);
        KurpesV2.SetActive(vert);
        KurpesV3.SetActive(vert);
        KurpesV4.SetActive(vert);
        KurpesV5.SetActive(vert);
        KurpesV6.SetActive(vert);
        

    }
    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            skait = 0;
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
            VirsjakaMT.SetActive(true);
            KleitasMT.SetActive(true);
            AksesuariMT.SetActive(true);
            GalvassegasMT.SetActive(true);
            ApaksdalaMT.SetActive(true);
            AugsdalaMT.SetActive(true);
            ApaviMT.SetActive(true);
            VirsjakasVT.SetActive(false);
            AksesuariVT.SetActive(false);
            GalvassegasVT.SetActive(false);
            ApaksdalaVT.SetActive(false);
            AugsdalaVT.SetActive(false);
            ApaviVT.SetActive(false);
            VirsjakaMT.GetComponent<Toggle>().isOn = false;
            KleitasMT.GetComponent<Toggle>().isOn = false;
            AksesuariMT.GetComponent<Toggle>().isOn = false;
            GalvassegasMT.GetComponent<Toggle>().isOn = false;
            ApaksdalaMT.GetComponent<Toggle>().isOn = false;
            AugsdalaMT.GetComponent<Toggle>().isOn = false;
            ApaviMT.GetComponent<Toggle>().isOn = false;
            VirsjakasVT.GetComponent<Toggle>().isOn = false;
            AksesuariVT.GetComponent<Toggle>().isOn = false;
            GalvassegasVT.GetComponent<Toggle>().isOn = false;
            ApaksdalaVT.GetComponent<Toggle>().isOn = false;
            AugsdalaVT.GetComponent<Toggle>().isOn = false;
            ApaviVT.GetComponent<Toggle>().isOn = false;
        }
        else if (skaitlis == 1)
        {
            skait = 1;
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
            VirsjakasVT.SetActive(true);
            KleitasMT.SetActive(false);
            AksesuariVT.SetActive(true);
            GalvassegasVT.SetActive(true);
            ApaksdalaVT.SetActive(true);
            AugsdalaVT.SetActive(true);
            ApaviVT.SetActive(true);
            VirsjakaMT.SetActive(false);
            KleitasMT.SetActive(false);
            AksesuariMT.SetActive(false);
            GalvassegasMT.SetActive(false);
            ApaksdalaMT.SetActive(false);
            AugsdalaMT.SetActive(false);
            ApaviMT.SetActive(false);
            VirsjakaMT.GetComponent<Toggle>().isOn = false;
            KleitasMT.GetComponent<Toggle>().isOn = false;
            AksesuariMT.GetComponent<Toggle>().isOn = false;
            GalvassegasMT.GetComponent<Toggle>().isOn = false;
            ApaksdalaMT.GetComponent<Toggle>().isOn = false;
            AugsdalaMT.GetComponent<Toggle>().isOn = false;
            ApaviMT.GetComponent<Toggle>().isOn = false;
            VirsjakasVT.GetComponent<Toggle>().isOn = false;
            AksesuariVT.GetComponent<Toggle>().isOn = false;
            GalvassegasVT.GetComponent<Toggle>().isOn = false;
            ApaksdalaVT.GetComponent<Toggle>().isOn = false;
            AugsdalaVT.GetComponent<Toggle>().isOn = false;
            ApaviVT.GetComponent<Toggle>().isOn = false;
        }
    }
    public void uzbiditsUzAttelaM()
    {
        if(skait == 0)
        {
            skanasAvots.PlayOneShot(skanaKoAtskanotM);
        }
        else if (skait == 1)
        {
            skanasAvots.PlayOneShot(skanaKoAtskanotV);

        }
    }

    public void kursorsNoietNoAttela()
    {
        skanasAvots.Stop();
    }
}
