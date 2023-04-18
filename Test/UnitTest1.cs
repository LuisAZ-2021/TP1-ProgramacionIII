using System.Collections.Specialized;

namespace Test
{
    public class UnitTest1
    {


        [Theory]
        [InlineData(500000)]
        public void cargarDiccionario(int cantidad)
        {

            HybridDictionary coleccion = new HybridDictionary();
;

            for (int i = 0; i < cantidad; i++)
            {
                
                coleccion.Add(i, i+10);

            }
            Assert.Equal(500000, coleccion.Count);
        }

        [Theory]
        [InlineData(500)]
        public void recorrerYEncontrarElemento(int cantidad)
        {

            HybridDictionary coleccion = new HybridDictionary();
            ;

            for (int i = 0; i < cantidad; i++)
            {

                coleccion.Add(i, i+10);

            }

            Assert.Equal(35, coleccion[25]);
        }


    }
}