using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeObject : MonoBehaviour
{
    // Time after which object will be destroyed
    [SerializeField]
    private float timeout = 2;
    // Saving enable time to calculate when to destroy itself
    private float startTime;

    public SlimeSpawner spawner;

    /// <summary>
    /// Unity's method called on object enable
    /// </summary>
    private void OnEnable()
    {
        startTime = Time.time;
    }

    /// <summary>
    /// Unity's method called every frame
    /// </summary>
    private void Update()
    {
 
    }

    private void OnDestroy()
    {
        spawner.slimes--;
    }
   
}
