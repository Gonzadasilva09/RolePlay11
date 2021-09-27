using System;

namespace roleplay
{
    public interface IPersonaje
    {
        string Name{get;set;}
        int Defense{get;set;}
        int Hp{get;set;}
        string Power{get;set;}
        int Damage{get;set;}
        bool Pocket{get;set;}
        int HpMax{get;set;}
        
    
        void AddItem(Item item);
        void RemoveItem(Item item);
        void Atack(IPersonaje personaje);
    }
}
