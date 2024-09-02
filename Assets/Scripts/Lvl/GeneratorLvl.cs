using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GeneratorLvl : MonoBehaviour
{
    public string file_name;
    public Vector3 start_coardinate = new Vector3(-4.5f, 0f, -4.5f);

    private GameObject element;
    private Vector3 coardinate;
    private string[] maze_map = new string[40];
    void Start()
    {
        Time.timeScale = 1;
        file_name = Application.dataPath + "/StreamingAssets/karta.txt";
        ReadMapFromFile();
        BuildMaze();
    }
    void ReadMapFromFile()
    {
        StreamReader file = new StreamReader(file_name);

        for (int i=0;i<maze_map.Length;i++)
        {
            maze_map[i] = file.ReadLine();
        }

        file.Close();
    }

    void BuildMaze()
    {

        for (int z = 0; z < 39; z++)
        {
            for (int x = 0; x < 39; x++)
            {
                switch (maze_map[z][x])
                {
                    case '0':
                        break;

                    case '1':
                        coardinate = start_coardinate + new Vector3(x, 0f, z) + transform.localPosition;
                        element = Instantiate(GetComponent<Elements>().x1_cube, coardinate, Quaternion.identity);
                        element.transform.parent = gameObject.transform;
                        break;

                    case '2':
                        coardinate = start_coardinate + new Vector3(x, 0f, z) + transform.localPosition;
                        element = Instantiate(GetComponent<Elements>().x2_cube, coardinate, Quaternion.identity);
                        element.transform.parent = gameObject.transform;
                        break;

                    case '3':
                        coardinate = start_coardinate + new Vector3(x, 0f, z) + transform.localPosition;
                        element = Instantiate(GetComponent<Elements>().x3_cube, coardinate, Quaternion.identity);
                        element.transform.parent = gameObject.transform;
                        break;

                    case 'p':
                        coardinate = start_coardinate + new Vector3(x, 0.5f, z) + transform.localPosition;
                        element = Instantiate(GetComponent<Elements>().player, coardinate, Quaternion.identity);
                        element.transform.parent = gameObject.transform;
                        break;

                    case 't':
                        coardinate = start_coardinate + new Vector3(x, -1f, z) + transform.localPosition;
                        element = Instantiate(GetComponent<Elements>().tyrret, coardinate, Quaternion.identity);
                        element.transform.parent = gameObject.transform;
                        break;

                    case 'f':
                        coardinate = start_coardinate + new Vector3(x, -0.2f, z) + transform.localPosition;
                        element = Instantiate(GetComponent<Elements>().grass, coardinate, Quaternion.identity);
                        element.transform.parent = gameObject.transform;
                        break;

                    case 'e':
                        coardinate = start_coardinate + new Vector3(x, 0f, z+0.5f) + transform.localPosition;
                        element = Instantiate(GetComponent<Elements>().enemy, coardinate, Quaternion.identity);
                        element.transform.parent = gameObject.transform;
                        break;

                    case 'b':
                        coardinate = start_coardinate + new Vector3(x, 0f, z) + transform.localPosition;
                        element = Instantiate(GetComponent<Elements>().bonus, coardinate, Quaternion.identity);
                        element.transform.parent = gameObject.transform;
                        break;

                }
            }
        }
    }
}
