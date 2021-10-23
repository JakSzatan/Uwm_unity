using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Random : MonoBehaviour
{
    public GameObject myPrefab;
    void Start()
    {
        List<(int,int)> ListOfPoints = new List<(int, int)>();
        while(ListOfPoints.Count<10)
        {
            System.Random var = new System.Random();
            int x = var.Next(0, 10);
            int z = var.Next(0, 10);
            if (!ListOfPoints.Contains((x, z)))
            {
                ListOfPoints.Add((x, z));
                Instantiate(myPrefab, new Vector3(x, 0, z), Quaternion.identity);
            }
            else continue;
            Debug.Log(x.ToString()+","+z.ToString());

        }
        
    }

}
