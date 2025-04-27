using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject originalCube;
    public Transform cubeParent;
    public float distanceBetweenCubes;

    void Start()
    {
        StartCoroutine(StopWatch());
        //for (int i = 0; i < 10; i++)
        //{
        //    var cubeClone = Instantiate(originalCube, new Vector3(i * distanceBetweenCubes, 1, 1), Quaternion.identity);
        //    cubeClone.transform.parent = cubeParent;
        //}
    }

    private float clock = 0;
    IEnumerator StopWatch()
    {
        while (true)
        {
            yield return null;
            Debug.Log(clock += Time.deltaTime);
        }
    }
}
