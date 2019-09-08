using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ChunkGO;
    void Start() {

        for (int i = 0; i < 2; i++){
           for (int j = 0; j < 2; j++){
                Instantiate(ChunkGO);
            }
        }
    }            


    // Update is called once per frame
    void Update()
    {
        
    }
}
