using NUnit.Framework;
using roleplay;

namespace Test.Library
{
[TestFixture]
    public class Tests
    {

        [Test]
        public void ElvesTest() 
        {
            
            Elves LegolasTest = new Elves("TesteoLegolas", 50, 100, "Flechazo Debug", 100);
            Dwarf EnanoTest = new Dwarf("GimliTest", 50, 100, "Mi hacha", 100);
            LegolasTest.Atack(EnanoTest);
            int hpexpected =  50;
            
            Assert.AreEqual(hpexpected, EnanoTest.Hp);

            LegolasTest.Heal(EnanoTest);
            hpexpected = 100;

            Assert.AreEqual(hpexpected, EnanoTest.Hp);

            EnanoTest.Atack(LegolasTest);
            hpexpected =  50;
            
            Assert.AreEqual(hpexpected, LegolasTest.Hp);    

            LegolasTest.Heal(LegolasTest);
            hpexpected = 100;

            Assert.AreEqual(hpexpected, LegolasTest.Hp);
        
        }
        public void pruebaenanos()
        {

            Dwarf Panza = new Dwarf("Fuerteychiquito",100,150,"patadamagica",170);
            Dwarf Peleador = new Dwarf("Elvaliente",150,180,"volar",170);
            Panza.Atack(Peleador);
            int hpexpected =  130;
            Assert.AreEqual(hpexpected, Peleador.Hp);
            Peleador.Atack(Peleador);
            var hpvolar =  70;
            Assert.AreEqual(hpvolar, Panza.Hp);
            //testeo de la clase enanos, verificación de que pueden atacar y recibir ataques los personajes
        }
        public void pruebaitems()
        {

            Item Testitem = new Item("test1",100,100,100);
            Elves TestElves = new Elves("testeralto",0,0,"testing power",0);
            Dwarf TestDwarf = new Dwarf("testerbajo",0,0,"testing power",0);
            Wizard TestWizz = new Wizard("testermagico",0,0,"testing power",0);

            int vida=100;
            int daño=100;
            int defensa=100;

            TestElves.AddItem(Testitem);
            TestDwarf.AddItem(Testitem);
            TestWizz.AddItem(Testitem);

            Assert.AreEqual(vida,TestElves.Hp);
            Assert.AreEqual(vida,TestDwarf.Hp);
            Assert.AreEqual(vida,TestWizz.Hp);

            Assert.AreEqual(daño,TestElves.Damage);
            Assert.AreEqual(daño,TestDwarf.Damage);
            Assert.AreEqual(daño,TestWizz.Damage);

            Assert.AreEqual(defensa,TestElves.Defense);
            Assert.AreEqual(defensa,TestDwarf.Defense);
            Assert.AreEqual(defensa,TestWizz.Defense);

            vida=0;
            daño=0;
            defensa=0;
            
            TestElves.RemoveItem(Testitem);
            TestDwarf.RemoveItem(Testitem);
            TestWizz.RemoveItem(Testitem);

            Assert.AreEqual(vida,TestElves.Hp);
            Assert.AreEqual(vida,TestDwarf.Hp);
            Assert.AreEqual(vida,TestWizz.Hp);

            Assert.AreEqual(daño,TestElves.Damage);
            Assert.AreEqual(daño,TestDwarf.Damage);
            Assert.AreEqual(daño,TestWizz.Damage);

            Assert.AreEqual(defensa,TestElves.Defense);
            Assert.AreEqual(defensa,TestDwarf.Defense);
            Assert.AreEqual(defensa,TestWizz.Defense);
            //Testing de objetos, desde su creacion, hasta equipar y removerlos de personajes de cada clase. Para verificar su correcto funcionamiento

        }
        public void WizardTest()
        {
            
            Wizard MagoTest = new Wizard("Harry Potter", 100, 100, "Wingardium Leviosa", 20);
            Dwarf EnanoTest = new Dwarf("Enano oscuro", 0, 100, "Fieraso", 100);
            Dwarf EnanoTest2 = new Dwarf("Enano oscuro", 0, 100, "Fieraso", 100);
            Book book = new Book("LA BIBILIA");
            Spell spell1 = new Spell("COLA FUEGO",50);
            Spell spell2 = new Spell("RAYO HIELO",50);
            Spell spell3 = new Spell("SINIESTRO",50);
            book.AddSpell(spell1); 
            book.AddSpell(spell2); 
            book.AddSpell(spell3); 

            MagoTest.Atack(EnanoTest);
            int hpexpected = 80;
            Assert.AreEqual(hpexpected, EnanoTest.Hp);

            MagoTest.AtackWithSpell(EnanoTest2);
            int hpexpected2= 50;
            Assert.AreEqual(hpexpected2, EnanoTest.Hp);
            // Testeo de la clase Wizard junto con los ataques basicos y ataques con el libro de hechizos
        }
    }
}