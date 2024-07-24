using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenBtn : MonoBehaviour
{
    public int[] foodOnCounter;
    private int Order;
    private int Table;
    public float Time;

    public void RecibeOrder()
    {
        Order = GlobalVariableManager.currentFood;
        StartCoroutine(CookingTime(Time));

    }

    IEnumerator CookingTime(float _time)
    {
        yield return new WaitForSeconds(_time);
    }
}
