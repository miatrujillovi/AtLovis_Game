using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreObjects : MonoBehaviour
{
    //Mejoras de Tienda
    public GameObject normalExpansion;
    public GameObject expansion1;
    public GameObject expansion2;
    public GameObject expansion3;
    public GameObject decoraciones1;
    public GameObject decoraciones2;
    public GameObject decoraciones3;
    public GameObject clientsNormal;
    public GameObject clients1;
    public GameObject clients2;
    public GameObject clients3;

    //Personajes
    public GameObject aerith;
    public GameObject flandre;
    public GameObject goldmary;
    public GameObject heidr;
    public GameObject ellen;
    public GameObject kotone;
    public GameObject nezuko;
    public GameObject shinobu;
    public GameObject yuliya;

    private void Start()
    {
        //Mejoras de Tienda
        normalExpansion = GlobalVariableManager.normalExpansion;
        expansion1 = GlobalVariableManager.expansion1;
        expansion2 = GlobalVariableManager.expansion2;
        expansion3 = GlobalVariableManager.expansion3;
        decoraciones1 = GlobalVariableManager.decoraciones1;
        decoraciones2 = GlobalVariableManager.decoraciones2;
        decoraciones3 = GlobalVariableManager.decoraciones3;
        clientsNormal = GlobalVariableManager.activeClientsNormal;
        clients1 = GlobalVariableManager.activeClientsExpansion1;
        clients2 = GlobalVariableManager.activeClientsExpansion2;
        clients3 = GlobalVariableManager.activeClientsExpansion3;

        DontDestroyOnLoad(normalExpansion);
        DontDestroyOnLoad(expansion1);
        DontDestroyOnLoad(expansion2);
        DontDestroyOnLoad(expansion3);
        DontDestroyOnLoad(decoraciones1);
        DontDestroyOnLoad(decoraciones2);
        DontDestroyOnLoad(decoraciones3);
        DontDestroyOnLoad(clientsNormal);
        DontDestroyOnLoad(clients1);
        DontDestroyOnLoad(clients2);
        DontDestroyOnLoad(clients3);

        //Personajes
        aerith = GlobalVariableManager.charAerith;
        flandre = GlobalVariableManager.charFlandre;
        goldmary = GlobalVariableManager.charGoldmary;
        heidr = GlobalVariableManager.charHeidr;
        ellen = GlobalVariableManager.charEllen;
        kotone = GlobalVariableManager.charKotone;
        nezuko = GlobalVariableManager.charNezuko;
        shinobu = GlobalVariableManager.charShinobu;
        yuliya = GlobalVariableManager.charYuliya;

        DontDestroyOnLoad(aerith);
        DontDestroyOnLoad(flandre);
        DontDestroyOnLoad(goldmary);
        DontDestroyOnLoad(heidr);
        DontDestroyOnLoad(ellen);
        DontDestroyOnLoad(kotone);
        DontDestroyOnLoad(nezuko);
        DontDestroyOnLoad(shinobu);
        DontDestroyOnLoad(yuliya);
    }
}
