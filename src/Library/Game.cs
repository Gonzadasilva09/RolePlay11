/*using System;
using System.Collections;


namespace roleplay
{
    public class Game{

        public void Heal(Elves personaje, dynamic personaje2)// En este caso decidimos que solamente los elfos tendrian la habilidad de curar, pero pueden curar a cualquier otro personaje
        {
            Console.WriteLine($"{personaje.Name} a realizado un hechizo de curacion");
            int curacion = personaje.Damage;
            
            if (curacion + personaje2.Hp < personaje2.HpMax){
                personaje2.Hp += curacion;
                Console.WriteLine($"A curado a {personaje2.Name} y su vida actual es {personaje2.Hp}");
            }
            else {
                if (curacion+ personaje2.Hp >= personaje2.HpMax){
                personaje2.Hp = personaje2.HpMax;
                Console.WriteLine($"A curado a {personaje2.Name} y tiene su vida completa");
                }
            }
            
        }

        public void AtackWithSpell(Wizard wizard, dynamic personaje)// Los wizards pueden tomar una accion especial, atacar con Spells contenidos por su libro de hechizos
        {
            Console.WriteLine($"{wizard.Name} abrio el libro {wizard.Book.Name}");
            int contador = 0;
            Console.WriteLine($"Cual hechizo le gustaria realizar...?");
            foreach(Spell spell in wizard.Book.Spells){
                Console.WriteLine($"{contador} - {spell.Name}");
                contador+=1;
            }
            int num = Convert.ToInt32(Console.ReadLine());
            dynamic hechizo = wizard.Book.Spells[num];
            int daño = hechizo.Power;

            if(personaje.Defense < daño)
            {
                int daño2 = daño - personaje.Defense;
                personaje.Hp = personaje.Hp - daño ;
                Console.WriteLine($"{personaje.Name} a recibido {daño} daño...");

                if(personaje.Hp > 0){

                    Console.WriteLine($"{personaje.Name} tiene {personaje.Hp} vida restante");
                }else{
                    Console.WriteLine($"{personaje.Name} a muerto a mano de {wizard.Name}");
                }
            }
            else
            {
            Console.WriteLine($"{personaje.Name} no a recibido daño ...");
            }
        }

    }

}
*/