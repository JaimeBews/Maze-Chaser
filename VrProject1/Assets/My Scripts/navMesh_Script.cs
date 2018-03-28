using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navMesh_Script : MonoBehaviour
{
    public NavMeshSurface[] surfaces;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < surfaces.Length; i++)
        {
            //  surfaces[i].BuildNavMesh();
        }
    }

    public void buildNavMesh()
    {
        for (int i = 0; i < surfaces.Length; i++)
        {
            surfaces[0] = GameObject.FindGameObjectWithTag("Respawn").GetComponent<NavMeshSurface>();
            surfaces[i].BuildNavMesh();
        }
    }

    public void UpdateMesh()
    {
        for (int i = 0; i < surfaces.Length; i++)
        {
            //  if (i != 0)
            surfaces[i] = null;
            //   surfaces[i].UpdateNavMesh();
        }
    }
}