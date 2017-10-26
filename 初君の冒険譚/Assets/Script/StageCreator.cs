using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class StageCreator : MonoBehaviour
{
    public TextAsset textAsset;

    public GameObject Block;
    public GameObject Player;

    public Vector3 CreatePos;
    public Vector3 SpaceScale = new Vector3(1.0f, 1.0f, 0f);

	// Use this for initialization
	void Start ()
    {
        CreateStage(CreatePos);
        CreatePos = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void CreateStage(Vector3 pos)
    {
        Vector3 OriginPos = pos;
        string StageTextData = textAsset.text;

        foreach(char c in StageTextData)
        {
            GameObject obj = null;

            if(c=='#')
            {
                obj = Instantiate(Block, pos, Quaternion.identity) as GameObject;
                obj.name = Block.name;
                pos.x += obj.transform.localScale.x;
            }
            else if(c=='P')
            {
                obj = Instantiate(Player, pos, Quaternion.identity) as GameObject;
                obj.name = Player.name;
                pos.x += obj.transform.lossyScale.x;
            }
            else if(c== '\n')
            {
                pos.y = SpaceScale.y;
                pos.x = SpaceScale.x;
            }
            else if(c==' ')
            {
                pos.x = SpaceScale.x;
            }
        }
    }
}
