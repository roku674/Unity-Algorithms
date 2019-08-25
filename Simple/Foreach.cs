using UnityEngine;

public class Foreach 
{
    /// <summary>
    /// Give it the name of the object you want to find and it will return it. If it returns null it was not found recommend you set up an if statement if (name != null)
    /// </summary>
    /// <param name="name">Name of the object you desire</param>
    /// <param name="rootGameObject">Parent gameobject it searches</param>
    /// <returns></returns>
    public GameObject ByName(string name, GameObject rootGameObject)
    {
        GameObject children = GetComponentsInChildren<Transform>();
        foreach (GameObject child in children)
        {
            if (child.name = name)
            {
                return child;
            }
        }

        return child;
    }
}

  
  