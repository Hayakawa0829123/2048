using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ピースの位置（配列番号）
/// </summary>
public class PieceCellPosition
{
    public int x = 0;
    public int y = 0;
    public PieceCellPosition(int x = 0, int y = 0)
    {
        this.x = x;
        this.y = y;
    }
    public PieceCellPosition(PieceCellPosition pos1, PieceCellPosition pos2)
    {
        this.x = pos1.x + pos2.x;
        this.y = pos1.y + pos2.y;
    }
}