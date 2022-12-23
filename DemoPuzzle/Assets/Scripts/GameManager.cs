using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public DadList listDadList = new DadList();
    public Transform one;
    public Transform two;
    private void Awake()
    {
       
    }
    void Start()
    {
        int randomList= Random.Range(0, listDadList.dadList.Count);
        int randomNumber = Random.Range(0, listDadList.dadList[0].gameObjects.Count);
        int randomNumber2 = Random.Range(0, listDadList.dadList[0].gameObjects.Count);
        if (randomNumber==randomNumber2)
        {
            if ((randomNumber == 0))
            {
                randomNumber2++;
            }
            if ((randomNumber == listDadList.dadList[0].gameObjects.Count))
            {
                randomNumber2--;
            }
            randomNumber2++;
        }
        
        listDadList.dadList[randomList].gameObjects[randomNumber].SetActive(true);
        listDadList.dadList[randomList].gameObjects[randomNumber].transform.position = one.transform.position;
         listDadList.dadList[randomList].gameObjects[randomNumber2].SetActive(true);
        listDadList.dadList[randomList].gameObjects[randomNumber].transform.position = two.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
[System.Serializable]
public class Dad
{

    public List<GameObject> gameObjects;

}
[System.Serializable]
public class DadList
{

    public List<Dad> dadList;

}
