.
.+using RepasoPersona.Core;
using Xunit;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        public Persona Cristian {get; set;}
        [Fact]
        public void Constructor()
        {
            Cristian = new Persona("Cristian", "Centurion", 0);
            Assert.Equal("Cristian", Cristian.Nombre);
            Assert.Equal("Centurion", Centurion.Apellido);
            Assert.Equal(0, 0.Efectivo);
        }
    }
}
