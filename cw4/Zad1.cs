using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int numberofCubes =10;
    int objectCounter = 0;
    public List<Material> Materials;
    // obiekt do generowania
    public GameObject block;
    
    void Start()
    {
        ///Znalezienie Granic Płaszczyzny
        MeshCollider mesh = GetComponent<MeshCollider>();
        float startx =mesh.bounds.center.x-mesh.bounds.extents.x;
        float starty = mesh.bounds.center.z - mesh.bounds.extents.z;

        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range((int)startx, (int)mesh.bounds.size.x).OrderBy(x => Guid.NewGuid()).Take(numberofCubes));
        List<int> pozycje_z = new List<int>(Enumerable.Range((int)starty, (int)mesh.bounds.size.z).OrderBy(x => Guid.NewGuid()).Take(numberofCubes));
 
        for (int i = 0; i < numberofCubes; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }

        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            GameObject newobj =Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            newobj.GetComponent<MeshRenderer>().material = this.Materials[UnityEngine.Random.Range(0,5)];
            yield return new WaitForSeconds(this.delay);
        }
        StopCoroutine(GenerujObiekt());
    }
}
