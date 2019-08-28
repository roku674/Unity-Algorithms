using UnityEngine;

public class Foreach 
{
    /// <summary>
    /// Give it the name of the object you want to find and it will return all of them. If it returns null it was not found recommend you set up an if statement if (name != null)
    /// </summary>
    /// <param name="name">Name of the object you desire</param>
    /// <param name="rootGameObject">Parent gameobject it searches</param>
    /// <returns></returns>
    public GameObject[] ByName(string name, GameObject rootGameObject)
    {
        GameObject[] childN = null;

        Transform[] children = rootGameObject.GetComponentsInChildren<Transform>();
        int childCount = 0;
        foreach (Transform child in children)
        {
            if (child.gameObject.name.Equals(name)) //if that doesn't work turn it into child.gameObject.name == name
            {
                childN[childCount] = child.gameObject; //assign to ChildN
                childCount++;
            }
        }

        return childN;
    }

    /// <summary>
    /// Give it the tag of the object you want to find and it will return all of them. If it returns null it was not found recommend you set up an if statement if (name != null)
    /// </summary>
    /// <param name="name">Name of the object you desire</param>
    /// <param name="rootGameObject">Parent gameobject it searches</param>
    /// <returns></returns>
    public GameObject[] ByTag(string tag, GameObject rootGameObject)
    {
        GameObject[] childN = null;

        Transform[] children = rootGameObject.GetComponentsInChildren<Transform>();
        int childCount = 0;
        foreach (Transform child in children)
        {
            if (child.gameObject.name.tag == tag) //if that doesn't work turn it into child.gameObject.name == name
            {
                childN[childCount] = child.gameObject; //assign to ChildN
                childCount++;
            }
        }

        return childN;
    }
}

  
  