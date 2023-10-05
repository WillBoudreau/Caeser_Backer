using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuStart : MonoBehaviour
{
    public int MMSc;
    // Start is called before the first frame update
   public void ScnTrans()
    {
        SceneManager.LoadScene(MMSc);
    }
}
