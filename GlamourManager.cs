﻿using System.Collections.Generic;

namespace WizGunCosmeticsAPI
{
    public static class GlamourManager
    {
        internal static List<Glamour> glamours = new List<Glamour>();

        public static Glamour New(ItemType itemType, string itemCode, string itemName, string itemDescription)
        {
            Glamour glamour = new Glamour(itemType, itemCode, itemName, itemDescription);
            glamours.Add(glamour);
            return glamour;
        }

        public static void CreateUnityObjects()
        {
            glamours.ForEach(x => x.CreateUnityObject());
        }
    }
}