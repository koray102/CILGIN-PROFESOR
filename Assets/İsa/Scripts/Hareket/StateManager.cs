using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{

    public class StateManager : MonoBehaviour
    {
        public float vertical;
        public float horizontal;

        public GameObject activeModel;
        public Animator anim;
        public Rigidbody rigid;

        public float delta;

        public void Init()
        {
            SetUpAnimator();
            rigid = GetComponent<Rigidbody>();
        }

        void SetUpAnimator()
        {
            if (activeModel == null)
            {
                anim = GetComponentInChildren<Animator>();
                if (anim != null)
                {
                    Debug.Log("no active model");
                }
                else
                {
                    activeModel = anim.gameObject;
                }
            }

            if (anim == null)
            {
                anim = activeModel.GetComponent<Animator>();
            }

            anim.applyRootMotion = false;
        }

        public void Tick(float d)
        {
            delta = d;
        }
    }
}
