using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class collision : MonoBehaviour
{
    int i = 0;
    GameObject[] gameobjs = new GameObject[14];
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("coin"))
        {
            other.gameObject.SetActive(false);
            gameobjs[i] = other.gameObject;
            i++;
            if(i > 13)
            {
                for (int a = 0; a < gameobjs.Length; a++)
                {
                    gameobjs[a].gameObject.SetActive(true);
                }
                i = 0;
            }
        }
    }
}
