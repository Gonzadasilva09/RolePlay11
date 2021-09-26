using System;
using System.Collections;

namespace roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game juego1 = new Game();

            Elves Legolas = new Elves("Legolas",0,100,"Flechazo entre ceja y ceja",20);

            Item FlechaDorada = new Item("Flecha Dorada", 25, 0, 0);

            Item GnomoBernardo = new Item("Gnomo Bernardo", 100, 50, 25);

            Wizard Richard = new Wizard("Richard",0,100,"Flechazo de hielo entre ceja y ceja",100);

            Item CopaAmerica = new Item ("Copa America",30,0,0);

            Dwarf enano = new Dwarf("Messi", 100, 100 ,"Zurda Magica",100);

            Spell spell = new Spell("Bola de fuego",50);

            Spell spell2 = new Spell("Mirada fea",50);

            Book book = new Book("DeathNote");

            book.AddSpell(spell); 
            
            book.AddSpell(spell2);

            Richard.AddBook(book);

            //juego1.AtackWithSpell(Richard,Legolas);




            //Legolas.AddItem(item);

            //Legolas.RemoveItem(item);

            //enano.AddItem(CopaAmerica);

            //juego1.Atack(Legolas,Richard);
            //juego1.Heal(Legolas,Richard);

            

        }
    }
}
