using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audioSource;//���y���Đ�����R���|�[�l���g

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�S�[��!");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        audioSource.Play();//play���\�b�h�����s���邱�ƂōĐ����邱�Ƃ��ł���

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
