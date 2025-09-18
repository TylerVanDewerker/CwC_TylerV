using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefab;
    public int animalIndex; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalsPrefab[animalIndex], new Vector3(0, 0, 20), animalsPrefab[animalIndex].transform.rotation);
        }
    }
}
