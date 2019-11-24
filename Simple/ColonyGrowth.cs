//Script Created by Alexander A Fields please check out http://www.perilousgames.com/
//Copyright © 2017, Perilous Games, Ltd. All rights reserved.

using System.Collections;
using UnityEngine;

public class ColonyGrowth : MonoBehaviour
{

    public GameObject colony;
    public int type;
    public int amountOfColonies;
    public float finalColMax = 1000000000;
    public float colMax;
    public float colPop;
    public float oldPop;
    public float colFloor = 1;
    public float food;
    public float water;
    public float planetType;
    //rates
    public float entertainment;
    public float medicine;
    public float taxes;
    public float bank;
    public float 
        a = 0.03125f, 
        b = 0.0625f,
        c = 1;

    public float growthRate;

    // Use this for initialization
    public void Start()
    {
        colony = GetComponentInParent<ColonySizer>().gameObject;
        //a = b / 2;
        StartCoroutine(Growth());
        //taxes must be 15-50
        colMax = 1000000000;
    }

    public IEnumerator Growth()
    {
        yield return new WaitForSecondsRealtime(1f);
        if ((colPop <= colMax) && (colPop >= colFloor))
        {
            //eat the food  
            food = food - colPop;
            water = water - colPop;
            medicine = medicine - colPop / 3;

            oldPop = colPop;
            growthRate = ((a * entertainment) + (b * medicine) - (-1 * (100 - taxes) * (bank + 1)) * 1.18f);
            growthRate = (growthRate * (colPop / finalColMax));

            //if not enough food decrement
            if (food < colPop || water < colPop)
            {
                colPop = colPop - growthRate;
                //Debug.Log("I'm decrementing");
            }

            //if food is still higher than the pop grow + food ceiling
            if (food >= colPop && water >= colPop)
            {
                colPop = colPop + growthRate;
                //Debug.Log("I'm incrementing");
            }
            //food ceiling + floor
            if (food > finalColMax && water > finalColMax)
            {
                colMax = finalColMax;
            }
            if (food <= 0)
            {
                food = 0;
            }
            if (water <= 0)
            {
                water = 0;
            }
            //population ceiling
            if (colPop >= finalColMax)
            {
                colPop = finalColMax;
            }
            //population floor
            if (colPop <= colFloor)
            {
                colPop = colFloor;
            }
        }       
    }      
}
