using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void bt_NovoJogo()
    {
        Application.LoadLevel("BackGround");
    }
    public void bt_Opções()
    {
        Debug.Log("Opçoes Ativada");
    }
    public void bt_Sair()
    {
        Debug.Log("Voce fecha o jogo");
        Application.Quit();
    }
}
