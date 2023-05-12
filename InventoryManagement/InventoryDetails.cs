using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    class InventoryDetails
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfPulses> typesOfPulses;
        public List<TypesOfWheat> typesOfWheat;
    }
    public  class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;

    }
    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int price;

    }
    public class TypesOfPulses
    {
        public string name;
        public int weight;
        public int price;

    }
}
