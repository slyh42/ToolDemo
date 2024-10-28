using Game.Prefabs;
using Game.Tools;

public partial class DemoToolSystem : NetToolSystem
{
    public override string toolID => "Demo Tool 1234567890";

    public override PrefabBase GetPrefab()
    {
        return null;
    }

    public override bool TrySetPrefab(PrefabBase prefab)
    {
        return false;
    }
}