using System.Collections.Generic;
using RimWorld;

namespace PrisonLabor.Core.BillAssignation
{
    public class BillAssignationUtility
    {
        private static readonly Dictionary<Bill, BillGroupData> Map = new Dictionary<Bill, BillGroupData>();

        public static GroupMode IsFor(Bill key)
        {
            if (!Map.ContainsKey(key))
                Map[key] = new BillGroupData();
            return Map[key].Mode;
        }

        public static void SetFor(Bill key, GroupMode value)
        {
            if (!Map.ContainsKey(key))
                Map[key] = new BillGroupData();
            Map[key].Mode = value;
        }

        public static BillGroupData GetData(Bill key)
        {
            if (!Map.ContainsKey(key))
                Map[key] = new BillGroupData();
            return Map[key];
        }

        public static void Remove(Bill bill)
        {
            Map.Remove(bill);
        }
    }
}