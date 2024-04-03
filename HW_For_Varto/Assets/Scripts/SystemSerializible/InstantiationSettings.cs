using UnityEngine;

[System.Serializable]
public class InstantiationSettings
{
    public GameObject prefab;
    public string name;
    public Transform instantiateDir;
    public Vector3 scale;
    public int mass;
    public int drag;
    public Material material;
}
