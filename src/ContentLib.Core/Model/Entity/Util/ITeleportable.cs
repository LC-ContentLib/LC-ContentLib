using UnityEngine;

namespace ContentLib.Core.Model.Entity.Util;
/// <summary>
/// Interface representing if an instance is teleportable or not. 
/// </summary>
public interface ITeleportable
{
    /// <summary>
    /// Teleports the instance to the given Vector3 Position in the gameworld. 
    /// </summary>
    /// <param name="position">The given position to teleport the instance to.</param>
    void Teleport(Vector3 position);
    
    /// <summary>
    /// Teleports the instance to the ship Teleporter. 
    /// </summary>
    void TeleportToShip();
}