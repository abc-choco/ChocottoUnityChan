using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    //PlayerのAnimatorコンポーネント保存用
    private Animator animator;

	// Use this for initialization
	void Start () {
        //PlayerのAnimatorコンポーネントを取得する
        this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		//Fを押すとIdle
        if(Input.GetKeyDown(KeyCode.F)){
            animator.SetBool("Idle",true);
        }

        //Qを押すとjab
        if(Input.GetKeyDown(KeyCode.Q)){
            animator.SetBool("Jab",true);
        }

        //Eを押すとHikick
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Hikick", true);
        }

        //Rを押すとSpinkick
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("Spinkick", true);
        }

	}

}