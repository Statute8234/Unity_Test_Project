using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToEnvironment : MonoBehaviour
{
    public GameObject Tree_Upper;
    public GameObject Tree_Lower;
    public GameObject Rock,Bush;
    Dictionary<int, GameObject> objects;
    public GameObject object1, object2, object3, object4, object5, object6;
    public int Max = 5;

    // Update is called once per frame
    void Start()
    {
        objects = new Dictionary<int, GameObject>();
        objects.Add(0, object1);
        objects.Add(1, object2);
        objects.Add(2, object3);
        objects.Add(3, object4);
        objects.Add(3, object5);
        objects.Add(3, object6);
    }
    void Update()
    {
        // add trees
        for (int i = 0; i < Max; i++)
        {
            float randintX = Random.Range(-22.26f, 175.26f);
            float randintY = Random.Range(-4.38f, 175.28f);
            GameObject Clone_Upper = Instantiate(Tree_Upper);
            GameObject Clone_Lower = Instantiate(Tree_Lower);
            Clone_Upper.transform.position = new Vector2(randintX, randintY);
            // clone underpart of the tree
            Vector2 position = Clone_Upper.transform.position;
            position.y -= 1.96f;
            Clone_Lower.transform.position = position;
        }
        // add rocks and add bush
        for (int i = 0; i < Max; i++)
        {
            float randintX = Random.Range(-0.08f, 199.06f);
            float randintY = Random.Range(-0.50f, 198.64f);
            GameObject Clone_Rocks = Instantiate(Rock);
            GameObject Clone_Bush = Instantiate(Bush);
            Clone_Rocks.transform.position = new Vector2(randintX, randintY);
            Clone_Bush.transform.position = new Vector2(randintX, randintY);
        }
        // anything else
        for (int i = 0; i < Max; i++)
        {
            int idex = Random.Range(0,objects.Count);
            float randintX = Random.Range(-0.08f, 199.06f);
            float randintY = Random.Range(-0.50f, 198.64f);
            GameObject Clone_object = Instantiate(objects[idex]);
            Clone_object.transform.position = new Vector2(randintX, randintY);
        }
        Max = 0;
    }
}
