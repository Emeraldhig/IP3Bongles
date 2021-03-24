using UnityEngine;
using System.Collections.Generic;

public static class PositionSaveGuide // Static class to remember bubbas position through out each scene.
{
    public static Dictionary<int, Vector3> positionSaver = new Dictionary<int, Vector3>();
}
