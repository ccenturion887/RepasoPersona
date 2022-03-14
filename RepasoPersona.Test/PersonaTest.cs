using RepasoPersona.core;
using System;
using Xunit;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        //public void constructor()
        public Persona Cristian {get; set;}
        public PersonaTest() => Cristian = new Persona ("Cristian", "Centurion", 0);
        [Fact]
        public void Constructor()
        {
            //Cristian = new Persona("Cristian", "Centurion", 0);
            Assert.Equal("Cristian", Cristian.Nombre);
            Assert.Equal("Centurion",Cristian.Apellido);
            Assert.Equal(0, Cristian.Efectivo);
        }
        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Cristian.Acreditar(1000);
            Assert.NotEqual(esperado, Cristian.Efectivo, 3);
        }
    }
}
