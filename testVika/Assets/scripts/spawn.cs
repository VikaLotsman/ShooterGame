using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class spawn : MonoBehaviour { 
    public GameObject DogPrefab;
    public Transform playerForDogs;
    public int num = 1;
    public List<enemy> enemies = new List<enemy>();
    public int sceneN;
    void ColorPart(Transform part,Color new_color)
    {
        part.GetComponent<Renderer>().material.color = new_color;
    }
    enemy SpawnDog()
    {
        Debug.Log("call");
        GameObject new_dog = Instantiate(DogPrefab);
        enemy en = new_dog.GetComponent<enemy>();
        en.player = playerForDogs;
        new_dog.transform.position = transform.position+new Vector3(Random.Range(-5f,5f),0,Random.Range(-5f,5f));
        Color random_color = new Color(Random.Range(-1f, 1f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        foreach (Transform part in en.parts)
        {
            ColorPart(part, random_color);
        }
        en.my_spawn = this;

        return en;
        
    }
    // Start is called before the first frame update
    void Start()
    {
         for(int i = 0; i <= num; i++)
        {
           enemies.Add( SpawnDog());
        }
       
    }

    public void CountDogs()
    {
        if (enemies.Count == 0)
        {
            win();
        }
    }


    public void win()
    {
        Debug.Log("Victory");
        SceneManager.LoadScene(sceneN);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
