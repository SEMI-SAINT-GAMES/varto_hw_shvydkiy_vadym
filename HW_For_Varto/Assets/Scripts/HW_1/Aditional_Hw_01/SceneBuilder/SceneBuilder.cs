using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SceneBuilder : MonoBehaviour
{
    [SerializeField] private InstantiationSettings playerSettings;
    [SerializeField] private InstantiationSettings enemySettings;
    [SerializeField] private CreatePrimitiveSettings leftBorderSettings;
    [SerializeField] private CreatePrimitiveSettings rightBorderSettings;
    void Start()
    {
        CubeCreatePrimitive(leftBorderSettings);
        CubeCreatePrimitive(rightBorderSettings);
        ObjectInstantiate(playerSettings);
        ObjectInstantiate(enemySettings);
        
    }
    private void ObjectInstantiate(InstantiationSettings settings)
    {
        GameObject obj = Instantiate(settings.prefab, settings.instantiateDir.position, Quaternion.identity) as GameObject;
        obj.name = settings.name;
        obj.transform.localScale = settings.scale;
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer)
        renderer.material = settings.material;
        Rigidbody rb = obj.AddComponent<Rigidbody>();
        rb.mass = settings.mass;
        rb.drag = settings.drag;
        rb.freezeRotation = true;
    }

    private void CubeCreatePrimitive(CreatePrimitiveSettings settings)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = settings.position;
        cube.transform.localScale = settings.scale;
        cube.name = settings.name;
        Renderer renderer = cube.GetComponent<Renderer>();
        if (renderer)
        renderer.material = settings.material;
        cube.AddComponent<BoxCollider>();
    }

    
}
