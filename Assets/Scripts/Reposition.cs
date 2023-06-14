using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Reposition : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
            return;

        Vector3 playetPosition = GameManager.instance.player.transform.position;
        Vector3 myPosition = transform.position; 


        float dirX = playetPosition.x - myPosition.x;

        float dirY = playetPosition.y - myPosition.y;


        float diffX = Mathf.Abs(dirX);

        float diffY = Mathf.Abs(dirY);

        Vector3 playerDir = GameManager.instance.player.inputVec;

        dirX = dirX > 0 ? 1 : -1;
        dirY = dirY > 0 ? 1 : -1;

        switch (transform.tag)
        {
            case "Ground":
                if(diffX > diffY)
                {
                    transform.Translate(Vector3.right * dirX * 37);
                } 
                else if (diffX < diffY)
                { 
                    transform.Translate(Vector3.up * dirY * 37);
                }
                break;
            case "Enemy":

                break;
        }

    }


}
