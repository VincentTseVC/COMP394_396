using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    // Reference to prefab of whatever type.
    [SerializeField]
    private T prefab;

    /// <summary>
    /// Creating new instance of prefab.
    /// </summary>
    /// <returns>New instance of prefab.</returns>
    public T GetNewInstance()
    {
        return Instantiate(prefab);
    }
}
