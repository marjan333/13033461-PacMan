using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    int Vertical, Horizontal; 
    private GameObject[] tiles; 
    //[SerializeField] private Sprite[] sprites; 

    // Start is called before the first frame update

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

    void Start()
    {
        Vertical = (int)Camera.main.orthographicSize; 
        Horizontal = Vertical * (Screen.width/ Screen.height); 
        Grid(); 
    }

    private void Grid(){   
        // i = row
        for(int i = 0; i < levelMap.GetLength(0); i++){
            // j = column
            for(int j = 0; j < levelMap.GetLength(1); j++){

                spawnTile(i,j);

                switch(levelMap[i,j]){
                    case 0:
                        Debug.Log("Nothing printed");
                    break; 
                    case 1:
                       // spawnTile(i, j);
                        Debug.Log(string.Format("an Outside Corner tile was drawn at {0} and {1}", i , j));
                    break; 
                    case 2: 
                        Debug.Log(string.Format("an Outside Wall tile was drawn at {0} and {1}", i , j));
                        //spawnTile(i, j);
                    break; 
                    case 3:
                        Debug.Log(string.Format("an Inside Corner tile was drawn at {0} and {1}", i , j));
                        //spawnTile(i, j);
                    break; 
                    case 4:
                        Debug.Log(string.Format("an Inside Wall tile was drawn at {0} and {1}", i , j));
                        //spawnTile(i, j);
                    break; 
                    case 5: 
                        Debug.Log(string.Format("a Standard Pellet tile was drawn at {0} and {1}", i , j));
                        //spawnTile(i, j);
                    break; 
                    case 6: 
                        Debug.Log(string.Format("a Power Pellet tile was drawn at {0} and {1}", i , j));
                        //spawnTile(i, j);
                    break; 
                    case 7: 
                        Debug.Log(string.Format("a T-Junction tile was drawn at {0} and {1}", i , j));
                        //spawnTile(i, j);
                    break; 
                    default:
                    break; 

                }
            }
        }
    }

    private void spawnTile(int x, int y){
        GameObject g = new GameObject("x:"+x+"y: "+y);
        g.transform.position = new Vector3(x - (Horizontal - 0.5f), y - (Vertical - 0.5f)); 
    }



    //  private Vector3 GridToWorldPosition(int x, int y){
    //     return new Vector3(x - (Horizontal - 0.5f), y - (Vertical - 0.5f)); 
    // }

    // private void spawnTile(int x, int y){
    //     int i; 
    //     int j; 
    //     for(int index = 0; index < tiles.GetLength(0); index++){
    //         if(tiles[index] == levelMap[i,j]){
    //             Instantiate(tiles[index], GridToWorldPosition(x, y), Quaternion.identity);
    //         }
    //     }
    // }
   
    // private void spawnTile(int x, int y){
    //     SpriteRenderer sr = Instantiate(tiles, GridToWorldPosition(x, y), Quaternion.identity).GetComponent<SpriteRenderer>();
    //     //sr.sprite = sprites[]; 
    // }

    // Update is called once per frame



    void Update()
    {
        
    }
}
