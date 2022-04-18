using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // config parameters

    [SerializeField] int breakableBlocks = 0;

    //cahced reference

    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void blockDestroyed()
    {
        breakableBlocks--;
        if( breakableBlocks <=0 )
        {
            sceneloader.LoadNextScene();
        }
    }
}
