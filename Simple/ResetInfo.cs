//Script Created by Alexander A Fields please check out http://www.perilousgames.com/
using UnityEngine;

public class ResetInfo : MonoBehaviour
{ 
    public GameObject[] info = new GameObject[14];

    /// <summary>
    /// pass the number in to deactivate the certain GameObject
    /// </summary>
    /// <param name="infoNum"></param>
    public void ChangeInfo(int infoNum)
    {
        InfoOff();
        info[infoNum].SetActive(true);
    }

    public void InfoOff()
    {
        for (int i = 0; i < info.Length; i++)
        {
            if (info[i] != null)
            {
                info[i].SetActive(false);
            }
        }
    }

}
