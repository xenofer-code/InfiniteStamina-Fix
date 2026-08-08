using Aurie;

namespace InfiniteStamina
{
    public class Mod : AurieModule
    {
        public override void OnUpdate()
        {
            // Vérifie si la variable existe avant de la modifier pour éviter le crash
            if (GML.HasGlobalVariable("stamina") && GML.HasGlobalVariable("max_stamina"))
            {
                GML.SetGlobalVariable("stamina", GML.GetGlobalVariable("max_stamina"));
            }
        }
    }
}
