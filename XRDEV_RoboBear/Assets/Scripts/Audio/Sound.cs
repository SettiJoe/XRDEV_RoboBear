using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 

{
    public string name;

    public AudioClip clip;

    public bool loop;
    
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    [Range(0f, 1f)] 
    public float spatialBlend;

    [Range(0f, 5f)]
    public float minDistance;
    [Range(0f, 5f)]
    public float maxDistance;

    [HideInInspector]
    public AudioSource source;

}
