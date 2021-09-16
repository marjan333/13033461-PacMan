using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int[,] levelMap = 
        { 
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7}, 
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4}, 
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4}, 
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4}, 
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3}, 
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5}, 
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4}, 
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3}, 
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4}, 
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4}, 
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3}, 
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0}, 
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0}, 
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0}, 
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0}, 
        };

        // i = row
        for(int i = 0; i < levelMap.GetLength(0); i++){
            // j = column
            for(int j = 0; j < levelMap.GetLength(1); j++){
                
                if(levelMap[i, j] == 1){
                    Debug.Log(string.Format("an Outside Corner tile was drawn at {0} and {1}", i , j));
                }
                else if(levelMap[i, j] == 2){
                    Debug.Log(string.Format("an Outside Wall tile was drawn at {0} and {1}", i , j));
                }
                else if(levelMap[i, j] == 3){
                     Debug.Log(string.Format("an Inside Corner tile was drawn at {0} and {1}", i , j));
                }
                else if(levelMap[i, j] == 4){
                    Debug.Log(string.Format("an Inside Wall tile was drawn at {0} and {1}", i , j));
                }
                else if(levelMap[i, j] == 5){
                    Debug.Log(string.Format("a Standard Pellet tile was drawn at {0} and {1}", i , j));
                }
                else if(levelMap[i, j] == 6){
                    Debug.Log(string.Format("a Power Pellet tile was drawn at {0} and {1}", i , j));
                }
                else if(levelMap[i, j] == 7){
                    Debug.Log(string.Format("a T-Junction tile was drawn at {0} and {1}", i , j));
                }
            }
        }
    }
}
