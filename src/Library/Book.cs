using System;
using System.Collections;

namespace roleplay
{
    public class Book 
    {
        public string Name{get;set;}
        public ArrayList Spells = new ArrayList(); 

       public void AddSpell(Spell spell) //Se le agrega hechizos al libro
       {
           this.Spells.Add(spell);
           Console.WriteLine($"Se agrego {this.Name}");
       }

       public Book(string name)// Se crea el objeto de tipo libro
       {
           this.Name=name;

           Console.WriteLine($"Se creo el libro {this.Name}");
       }

       public void ShowBook()// Muestra el libro con sus respectivos hechizos
       {
           foreach(Spell spell in this.Spells){
               Console.WriteLine(spell.Name);
           }
       }


    } 
}