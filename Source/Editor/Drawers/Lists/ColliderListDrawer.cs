#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(ColliderList))]
    public class ColliderListDrawer : AtomDrawer<ColliderList> { }
}
#endif