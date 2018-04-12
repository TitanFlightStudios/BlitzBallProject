using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class BlitzBallMatchController : MonoBehaviour, SkillzMatchDelegate
{

    public void OnMatchWillBegin(SkillzSDK.Match matchInfo)
    {
        SceneManager.LoadScene("WallBall_v2_FirstLevel");
    }

    public void OnSkillzWillExit()
    {
        SceneManager.LoadScene("WallBall_v2_MainMenu");
    }

}
