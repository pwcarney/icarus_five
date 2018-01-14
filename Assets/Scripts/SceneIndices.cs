﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SceneIndices
{
    private static LeaderboardDriver instance;

    public static int GetIndex(string input)
    {
        switch (input)
        {
            case "Pyramids":
                return 1;
            case "Stonehenge":
                return 2;
        }
        return 0;
    }

}
