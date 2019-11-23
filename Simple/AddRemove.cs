//Script Created by Alexander Fields property of Perilous Games Ltd.
//Copyright © 2019, Perilous Games, Ltd. All rights reserved.

public class AddRemove
{
    /// <summary>
    /// adds player from stack
    /// </summary>
    /// <param name="playerArr">Player array</param>
    /// <param name="ship">player you want to remove</param>
    /// <param name="playerCounter">what the player counter starts as</param>
    /// <param name="count">the player counter that it spits out</param>
    /// <returns></returns>
    public static GameObject[] AddPlayer(GameObject[] playerArr, GameObject ship, int playerCounter, out int count)
    {
        if (playerCounter >= playerArr.Length)
        {
            playerArr = new GameObject[playerArr.Length + 1];
            Array.Resize(ref playerArr, playerArr.Length + 1);
        }

        for (int i = 0; i < playerArr.Length; i++)
        {
            if (playerArr[i] == null)
            {
                playerArr[i] = ship;
                playerCounter++;
                break;
            }
        }
        count = playerCounter;
        return playerArr;
    }

    /// <summary>
    /// Removes player from stack
    /// </summary>
    /// <param name="playerArr">Player array</param>
    /// <param name="ship">player you want to remove</param>
    /// <param name="playerCounter">what the player counter starts as</param>
    /// <param name="count">the player counter that it spits out</param>
    /// <returns></returns>
    public static GameObject[] RemovePlayer(GameObject[] playerArr, GameObject ship, int playerCounter, out int count)
    {
        for (int i = 0; i < playerArr.Length; i++)
        {
            if (playerArr[i] == ship)
            {
                playerArr[i] = null;

                playerCounter--;
                for (int j = i; j < playerArr.Length; j++)
                {
                    //store the one below in the one above
                    if (j + 1 < playerArr.Length)
                    {
                        playerArr[j] = playerArr[j + 1];
                    }
                }
            }
        }
        count = playerCounter;
        return playerArr;
    }
}
}