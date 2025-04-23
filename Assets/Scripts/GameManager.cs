using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject originalCube;
    public Transform cubeParent;
    public float distanceBetweenCubes;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var cubeClone = Instantiate(originalCube, new Vector3(i * distanceBetweenCubes, 1, 1), Quaternion.identity);
            cubeClone.transform.parent = cubeParent;
        }
    }
}
